using BannerKings;
using BannerKings.Behaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BannerKings1259.Behaviors
{
    internal class AD1259Behaviors : BannerKingsBehavior
    {
        public override void RegisterEvents()
        {
            CampaignEvents.OnNewGameCreatedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnNewGameCreated));

            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(this, new Action<CampaignGameStarter>(this.OnSessionLaunchedEvent));
        }

        public override void SyncData(IDataStore dataStore)
        {
        }

        private void OnNewGameCreated(CampaignGameStarter starter) 
        {
            BannerKingsConfig.Instance.TitlesGeneratorPath = BasePath.Name + "Modules/BannerKings1259/ModuleData/titles.xml";
        }

        
        //Since banner kings adds titles, delete anno domini defined titles (e.g. {name}, king of spain)
        private void OnSessionLaunchedEvent(CampaignGameStarter gameStarter)
        {
            foreach (Hero hero in Hero.AllAliveHeroes)
            {
                string fullName = hero.Name.ToString();

                int commaIndex = fullName.IndexOf(',');
                if (commaIndex > 0)
                {
                    string cleanName = fullName.Substring(0, commaIndex).Trim();

                    TextObject nameText = new TextObject(cleanName);
                    hero.SetName(nameText, nameText);
                }
            }
        }
    }
}
