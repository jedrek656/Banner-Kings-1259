using BannerKings;
using BannerKings.Behaviours.Diplomacy.Wars;
using BannerKings.Managers.Cultures;
using BannerKings.Managers.Education.Books;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Innovations.Eras;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using BannerKings.Managers.Shipping;
using BannerKings.Managers.Titles.Governments;
using BannerKings1259.Behaviors;
using BannerKings1259.Divinties;
using BannerKings1259.Goverments;
using BannerKings1259.Languages;
using BannerKings1259.Patches;
using BannerKings1259.Religions;
using BannerKings1259.ShippingLanes;
using BannnerKings1259.Settings;
using HarmonyLib;
using SandBox.CampaignBehaviors;
using System;
using System.IO;
using System.Reflection;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;



namespace BannerKings1259
{
    public class BannerKings1259 : MBSubModuleBase
    {
        internal static void LogMessage(string message)
        {
            File.AppendAllText(BannerKings1259.path + BannerKings1259.fileName, DateTime.Now.ToString() + ": " + message + "\n");
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            if (!(gameStarterObject is CampaignGameStarter campaignStarterr))
            {
                return;
            }
            CampaignGameStarter campaignStarter = gameStarterObject as CampaignGameStarter;

            //campaignStarter.AddBehavior(new PopeNameGeneratorBehavior());

            BannerKingsConfig.Instance.AddInitializer(AD1259Languages.Instance);
            BannerKingsConfig.Instance.AddInitializer(AD1259ShippingLanes.Instance);
            BannerKingsConfig.Instance.AddInitializer(AD1259Divinties.Instance);
            BannerKingsConfig.Instance.AddInitializer(AD1259FaithGroups.Instance);
            BannerKingsConfig.Instance.AddInitializer(AD1259Faiths.Instance);
            BannerKingsConfig.Instance.AddInitializer(AD1259Religions.Instance);

            BannerKingsConfig.Instance.AddInitializer(AD1259Titles.Instance);
            //BannerKingsConfig.Instance.AddInitializer(AD1259Goverments.Instance);
            

            campaignStarter.AddBehavior(new AD1259Behaviors());
        }

        protected override void OnSubModuleLoad()
        {
            LogMessage("Starting SubModule Load");
            base.OnSubModuleLoad();
            BannerKings1259.harmony.PatchAll();
        }

        public static readonly Harmony harmony = new Harmony("BannerKings1259");

        public static readonly string path = BasePath.Name + "Modules/BannerKings1259/";

        public static readonly string fileName = "BannerKings1259Log.txt";
    }
}
