//CLASS MADE TO ALLOW FOR DYNAMIC POPE NAME GENERTOR WITH INCREMENTING NUMBERS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.SaveSystem;
using BannerKings1259.Helpers;

namespace BannerKings1259
{
    public class PopeNameGeneratorBehavior : CampaignBehaviorBase
    {
        //[SaveableField(1)]
        private Dictionary<string, int> highestNumber;

        public override void RegisterEvents()
        {
        }
        
        public override void SyncData(IDataStore dataStore)
        {
            /*dataStore.SyncData(
                "papal_names_numbers",
                ref highestNumber
                );
            if (highestNumber == null) InitializeDefaults();*/
            InitializeDefaults();
        }

        private void InitializeDefaults()
        {
            this.highestNumber = new Dictionary<string, int>
            {
                {"Urban", 3 },
                {"Gregory", 9 },
                {"Clement", 3 },
                {"Innocent", 4},
                {"Adrian", 4},
                {"John", 20}
            };
        }
        
        private int GetNextNumber(string name)
        {
            highestNumber.TryGetValue(name, out var number);
            number++;
            highestNumber[name] = number;
            return number;
        }

        public TextObject GenerateRandomName()
        {
            if (this.highestNumber == null)
            {
                InitializeDefaults();
            }

            string name = this.highestNumber.Keys.ToArray<string>().GetRandomElement<string>();
            int number = GetNextNumber(name);

            return new TextObject($"{name} {Helpers.Helpers.ToRoman(number)}", null);
        }
    }
}
