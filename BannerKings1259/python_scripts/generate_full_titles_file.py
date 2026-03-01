#GENERATES BASIC WORKING TITLES.XML FILE. WORKS BY READING KINGDOMS FILE, CREATING KINGDOMS. DUCHIES ARE GENERATED SUCH THAT ALL TOWNS
#OWNED BY ONE CLAN MAKE A DUCHY. COUNTIES ARE GENERATED DIRECTLY FROM SETTLEMENTS. BARONIES ARE AUTO ASSIGNED TO THE CLOSEST TOWN.
#FOR NOW DUCHIES HAVE PLACEHOLDER NAME WITH ID OF CLAN THAT OWSN THEM 
import xml.etree.ElementTree as ET
from pathlib import Path
from collections import defaultdict
import math


#clan->kingdom maps
KINGDOM_MAP = {
    "lithuania": "baltic",

    "almohad_caliphate": "almohad",

    "holy": "germanic",

    "tlemcen_algeria": "zyan",

    "empire": "empire_north",

    "empire_s": "empire_south",

    "empire_w": "empire_west"
}

#If kingdom has no towns(only castle)
MANUAL_KINGDOMS = {
    "verona": {
        "duchy_name": "verona",
        "county_settlement_id": "castle_EN1",
    }
}

KINGDOMS_XML = "kingdoms.xml"
SETTLEMENTS_XML = "settlements.xml"
CLANS_DIR = "spclans"
OUTPUT_XML = "titles.xml"


def normalize_kingdom(value):
    return KINGDOM_MAP.get(value, value)


def kingdom_from_clan(clan_id):
    prefix = clan_id.replace("cs_", "").replace("clan_", "").rsplit("_", 1)[0]
    return normalize_kingdom(prefix)

def dist(a, b):
    return math.sqrt((a["x"] - b["x"]) ** 2 + (a["y"] - b["y"]) ** 2)



def load_clan_leaders(folder):
    leaders = {}
    for path in Path(folder).glob("*.xml"):
        tree = ET.parse(path)
        root = tree.getroot()

        for faction in root.findall(".//Faction"):
            cid = faction.get("id")
            owner = faction.get("owner")
            if cid and owner:
                leaders[cid] = owner.replace("Hero.", "")

    return leaders


clan_leaders = load_clan_leaders(CLANS_DIR)


settlements_tree = ET.parse(SETTLEMENTS_XML)
settlements_root = settlements_tree.getroot()

towns_by_kingdom = defaultdict(list)
castles_by_kingdom = defaultdict(list)

for s in settlements_root.findall("Settlement"):
    town_comp = s.find("./Components/Town")
    if town_comp is None:
        continue

    is_castle = town_comp.get("is_castle") == "true"
    clan_id = s.get("owner").replace("Faction.", "")
    kingdom = kingdom_from_clan(clan_id)

    entry = {
        "id": s.get("id"),
        "clan": clan_id,
        "kingdom": kingdom,
        "x": float(s.get("posX")),
        "y": float(s.get("posY")),
    }

    if is_castle:
        castles_by_kingdom[kingdom].append(entry)
    else:
        towns_by_kingdom[kingdom].append(entry)


kingdoms_tree = ET.parse(KINGDOMS_XML)
kingdoms_root = kingdoms_tree.getroot()


base = ET.Element(
    "base",
    {
        "xmlns:xsi": "http://www.w3.org/2001/XMLSchema-instance",
        "xmlns:xsd": "http://www.w3.org/2001/XMLSchema",
        "type": "string",
    },
)

titles = ET.SubElement(base, "titles", {"autoGenerate": "true"})

counties_by_kingdom = defaultdict(list)

for k in kingdoms_root.findall(".//kingdom"):
    raw_id = k.get("faction")
    kingdom_id = normalize_kingdom(raw_id)

    kingdom_el = ET.SubElement(titles, "kingdom", k.attrib)

    #group towns by clan
    towns_by_clan = defaultdict(list)
    for t in towns_by_kingdom.get(kingdom_id, []):
        towns_by_clan[t["clan"]].append(t)

    #duchies only for clans with towns
    for clan, clan_towns in towns_by_clan.items():
        leader = clan_leaders.get(clan)
        if not leader:
            continue

        duchy = ET.SubElement(
            kingdom_el,
            "duchy",
            {
                "name": f"{{=duchy_{clan}}}{clan}",
                "deJure": leader,
            },
        )

        for town in clan_towns:
            county = ET.SubElement(
                duchy,
                "county",
                {
                    "settlement": town["id"],
                    "deJure": leader,
                },
            )

            counties_by_kingdom[kingdom_id].append(
                {
                    "element": county,
                    "x": town["x"],
                    "y": town["y"],
                }
            )

    #Manual fallback for verona (one castle only)
    if kingdom_id in MANUAL_KINGDOMS and not towns_by_clan:
        manual = MANUAL_KINGDOMS[kingdom_id]

        castles = castles_by_kingdom.get(kingdom_id, [])
        if not castles:
            continue

        castle = castles[0]
        leader = clan_leaders.get(castle["clan"])
        if not leader:
            continue

        duchy = ET.SubElement(
            kingdom_el,
            "duchy",
            {
                "name": f"{{=duchy_{manual['duchy_name']}}}{manual['duchy_name']}",
                "deJure": leader,
            },
        )

        county = ET.SubElement(
            duchy,
            "county",
            {
                "settlement": manual["county_settlement_id"],
                "deJure": leader,
            },
        )

        counties_by_kingdom[kingdom_id].append(
            {
                "element": county,
                "x": castle["x"],
                "y": castle["y"],
            }
        )

#assign baronies by the closest town (perhaps better logic could be figured out later)

for kingdom_id, castles in castles_by_kingdom.items():
    counties = counties_by_kingdom.get(kingdom_id)
    if not counties:
        continue

    for castle in castles:
        #skip the castles defined at the top
        if castle["id"] in [x["county_settlement_id"] for x in MANUAL_KINGDOMS.values()]: continue
        
        closest = min(counties, key=lambda c: dist(castle, c))
        leader = clan_leaders.get(castle["clan"])

        ET.SubElement(
            closest["element"],
            "barony",
            {
                "settlement": castle["id"],
                "deJure": leader,
            },
        )



tree = ET.ElementTree(base)
tree.write(OUTPUT_XML, encoding="utf-8", xml_declaration=True)

print(f"titles.xml generated → {OUTPUT_XML}")