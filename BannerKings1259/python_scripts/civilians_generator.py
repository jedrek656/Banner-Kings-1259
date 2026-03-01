import xml.etree.ElementTree as ET
from xml.dom import minidom

OUTPUT_FILE = "bk_civilians.xml"


# PREACHERS
RELIGIONS = [
    "catholicism",
    "armenian_catholicism",
    "eastern_orthodoxy",
    "krstjani",
    "catharism",
    "sunnism",
    "shiism",
    "judaism",
    "tengrism",
    "buddhism",
    "romuva",
    "saami"
]


def create_preacher_xml(religion_name, level = 1, culture = "Culture.empire"):
    npc_id = f"bannerkings_preacher_{religion_name.lower()}_{level}"

    npc = ET.Element("NPCCharacter", {
        "id": npc_id,
        "name": "{FIRSTNAME}",
        "voice": "softspoken",
        "age": "55",
        "is_template": "true",
        "is_female": "false",
        "default_group": "Infantry",
        "is_hero": "false",
        "culture": f"{culture}",
        "occupation": "Preacher"
    })

    # Face
    face = ET.SubElement(npc, "face")
    ET.SubElement(face, "face_key_template", {
        "value": "BodyProperty.villager_sturgia"
    })

    # Traits
    traits = ET.SubElement(npc, "Traits")

    trait_values = {
        "WandererEquipment": "1",
        "PeltastFightingSkills": "2",
        "ScoutSkills": "1",
        "Surgeon": "3",
        "Calculating": "1",
        "Mercy": "1"
    }

    for trait_id, value in trait_values.items():
        ET.SubElement(traits, "Trait", {
            "id": trait_id,
            "value": value
        })

    # Equipments
    equipments = ET.SubElement(npc, "Equipments")

    for civilian in [False, True]:
        roster_attrs = {}
        if civilian:
            roster_attrs["civilian"] = "true"

        roster = ET.SubElement(equipments, "EquipmentRoster", roster_attrs)

        ET.SubElement(roster, "equipment", {
            "slot": "Body",
            "id": "Item.monk_robe"
        })

        ET.SubElement(roster, "equipment", {
            "slot": "Leg",
            "id": "Item.folded_town_boots"
        })

    return npc


def prettify(element):
    rough_string = ET.tostring(element, 'utf-8')
    reparsed = minidom.parseString(rough_string)
    return reparsed.toprettyxml(indent="  ")


def main():
    root = ET.Element("NPCCharacters")

    for religion in RELIGIONS:
        preacher = create_preacher_xml(religion)
        root.append(preacher)

    pretty_xml = prettify(root)

    with open(OUTPUT_FILE, "w", encoding="utf-8") as f:
        f.write(pretty_xml)

    print(f"XML file successfully generated: {OUTPUT_FILE}")


if __name__ == "__main__":
    main()