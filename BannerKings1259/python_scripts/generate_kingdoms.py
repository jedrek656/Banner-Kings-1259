#PREPARE KINGDOMS WITH DEFAULT SETTINGS (FEUDAL, HEREDITARY)
import os
import xml.etree.ElementTree as ET
from xml.dom import minidom


INPUT_FOLDER = "input_xmls"
OUTPUT_FILE = "kingdoms.xml"

def read_kingdoms_from_folder(folder_path):
    kingdoms = []

    for filename in os.listdir(folder_path):
        if filename.lower().endswith(".xml"):
            file_path = os.path.join(folder_path, filename)
            try:
                tree = ET.parse(file_path)
                root = tree.getroot()

                for kingdom in root.findall(".//Kingdom"):
                    kingdom_id = kingdom.get("id")
                    owner = kingdom.get("owner")
                    fullName = kingdom.get("name")
                    fullName = fullName.split("}")[-1]
                    fullName = f"{{=!}}{fullName}"

                    if kingdom_id and owner:
                        kingdoms.append({
                            "faction": kingdom_id,
                            "deJure": owner,
                            "fullName": fullName
                        })

                    print(fullName)

            except ET.ParseError as e:
                print(f"Skipping invalid XML file {filename}: {e}")

    return kingdoms


def prettify_xml(element):
    rough_string = ET.tostring(element, encoding="utf-8", short_empty_elements=False)
    reparsed = minidom.parseString(rough_string)
    return reparsed.toprettyxml(indent="  ")


def create_output_xml(kingdoms, output_file):
    base = ET.Element(
        "base",
        {
            "xmlns:xsi": "http://www.w3.org/2001/XMLSchema-instance",
            "xmlns:xsd": "http://www.w3.org/2001/XMLSchema",
            "type": "string"
        }
    )

    titles = ET.SubElement(base, "titles", {"autoGenerate": "false"})

    for k in kingdoms:
        el = ET.SubElement(
            titles,
            "kingdom",
            {
                "faction": k["faction"],
                "fullName": k["fullName"],
                "government": "Feudal",
                "succession": "Hereditary",
                "inheritance": "Primogeniture",
                "genderLaw": "Agnatic",
                "deJure": k["deJure"]
            }
        )
        el.text = "\n"
        

    pretty_xml = prettify_xml(base)

    with open(output_file, "w", encoding="utf-8") as f:
        f.write(pretty_xml)


if __name__ == "__main__":
    kingdoms_data = read_kingdoms_from_folder(INPUT_FOLDER)
    create_output_xml(kingdoms_data, OUTPUT_FILE)
    print(f"Created {OUTPUT_FILE} with {len(kingdoms_data)} kingdoms.")