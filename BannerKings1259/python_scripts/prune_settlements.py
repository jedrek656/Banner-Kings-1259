#PURPOSE: REDUCE SETTLEMENTS FILE TO TOWNS AND CASTLES ONLY (VILLAGES ARE NOT NEEDED IN TITLES.XML)

import xml.etree.ElementTree as ET

INPUT_XML = "settlements.xml"
OUTPUT_XML = "settlements_pruned.xml"


def is_town_or_castle(settlement):
    components = settlement.find("Components")
    if components is None:
        return False

    town = components.find("Town")
    return town is not None


def prune_settlements(input_path, output_path):
    tree = ET.parse(input_path)
    root = tree.getroot()

    for settlement in list(root.findall("Settlement")):
        if not is_town_or_castle(settlement):
            root.remove(settlement)
            continue

        locations = settlement.find("Locations")
        if locations is not None:
            settlement.remove(locations)

        common_areas = settlement.find("CommonAreas")
        if common_areas is not None:
            settlement.remove(common_areas)

    tree.write(output_path, encoding="utf-8", xml_declaration=True)


if __name__ == "__main__":
    prune_settlements(INPUT_XML, OUTPUT_XML)