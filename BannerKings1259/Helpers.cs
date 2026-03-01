using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;

namespace BannerKings1259.Helpers
{
    internal class Helpers
    {
        public static string getRomeCityID()
        {
            return "town_V6";
        }

        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException(nameof(number), "Tried to generate Pope Name with numeral argument larger than 3999 or lower than 1");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900);
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new Exception("Impossible state reached");
        }

        public static bool IsCultureCatholic(CultureObject culture)
        {
            return culture.StringId == "aragonese" ||
                culture.StringId == "bohemia" ||
                culture.StringId == "castile" ||
                culture.StringId == "crusader" ||
                culture.StringId == "danish" ||
                culture.StringId == "england" ||
                culture.StringId == "vlandia" ||
                culture.StringId == "battania" ||
                culture.StringId == "germanic" ||
                culture.StringId == "hungarian" ||
                culture.StringId == "empire" ||
                culture.StringId == "genoa" ||
                culture.StringId == "santiago" ||
                culture.StringId == "templar" ||
                culture.StringId == "lazarus" ||
                culture.StringId == "hospitaller" ||
                culture.StringId == "norwegian" ||
                culture.StringId == "poland" ||
                culture.StringId == "portuguese" ||
                culture.StringId == "scottish" ||
                culture.StringId == "scottish" ||
                culture.StringId == "sturgia" ||
                culture.StringId == "teutonic" ||
                culture.StringId == "wales";
        }

        public static bool IsCultureSunni(CultureObject culture)
        {
            return culture.StringId == "aserai" ||
                culture.StringId == "andalus" ||
                culture.StringId == "darshi" ||
                culture.StringId == "turkish";
        }

        public static bool IsCultureOrthodox(CultureObject culture)
        {
            return culture.StringId == "bulgaria" ||
                culture.StringId == "greek" ||
                culture.StringId == "georgia" ||
                culture.StringId == "halych" ||
                culture.StringId == "latin" ||
                culture.StringId == "rus" ||
                culture.StringId == "serbia";
        }
    }
}
