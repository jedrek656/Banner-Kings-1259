using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings1259.Religions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.Library;
using TaleWorlds.ObjectSystem;

namespace BannerKings1259.Religions
{
    internal class AD1259Religions : DefaultTypeInitializer<AD1259Religions, Religion>
    {
        public Religion Catholicism { get; } = new Religion("catholicism");
        public Religion ArmenianCatholicism { get; } = new Religion("armenian_catholicism");
        public Religion EasternOrthodoxy { get; } = new Religion("eastern_orthodoxy");
        public Religion Krstjani { get; } = new Religion("krstjani");
        public Religion Catharism { get; } = new Religion("catharism");
        public Religion SunniIslam { get; } = new Religion("sunnism");
        public Religion ShiaIslam { get; } = new Religion("shiism");
        public Religion Judaism { get; } = new Religion("judaism");
        public Religion Tengrism { get; } = new Religion("tengrism");
        public Religion Buddhism { get; } = new Religion("buddhism");
        public Religion Romuva { get; } = new Religion("romuva");
        public Religion SaamiShamanism { get; } = new Religion("saami");
        
        public override IEnumerable<Religion> All 
        {
            get
            {
                yield return Catholicism;
                yield return ArmenianCatholicism;
                yield return EasternOrthodoxy;
                yield return Krstjani;
                yield return Catharism;
                yield return SunniIslam;
                yield return ShiaIslam;
                yield return Tengrism;
                yield return Buddhism;
                yield return Romuva;
                yield return SaamiShamanism;
                yield return Judaism;
            }
        }

        public override void Initialize()
        {
            MBReadOnlyList<CultureObject> cultures =
            Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();

            List<CultureObject> validCultures = new List<CultureObject>();
            foreach (var culture in cultures)
            {
                if (!culture.IsBandit)
                {
                    validCultures.Add(culture);
                }
            }

            CultureObject aragonese = MBObjectManager.Instance.GetObject<CultureObject>("aragonese");
            CultureObject armenia = MBObjectManager.Instance.GetObject<CultureObject>("armenia");
            CultureObject baltic = MBObjectManager.Instance.GetObject<CultureObject>("baltic");
            CultureObject berber = MBObjectManager.Instance.GetObject<CultureObject>("aserai");
            CultureObject bohemia = MBObjectManager.Instance.GetObject<CultureObject>("bohemia");
            CultureObject bosnia = MBObjectManager.Instance.GetObject<CultureObject>("bosnia");
            CultureObject bulgaria = MBObjectManager.Instance.GetObject<CultureObject>("bulgaria");
            CultureObject castile = MBObjectManager.Instance.GetObject<CultureObject>("castile");
            CultureObject crusader = MBObjectManager.Instance.GetObject<CultureObject>("crusader");
            CultureObject danish = MBObjectManager.Instance.GetObject<CultureObject>("danish");
            CultureObject england = MBObjectManager.Instance.GetObject<CultureObject>("england");
            CultureObject france = MBObjectManager.Instance.GetObject<CultureObject>("vlandia");
            CultureObject gealic = MBObjectManager.Instance.GetObject<CultureObject>("battania");
            CultureObject georgia = MBObjectManager.Instance.GetObject<CultureObject>("georgia");
            CultureObject germanic = MBObjectManager.Instance.GetObject<CultureObject>("germanic");
            CultureObject andalus = MBObjectManager.Instance.GetObject<CultureObject>("andalus");
            CultureObject greek = MBObjectManager.Instance.GetObject<CultureObject>("greek");
            CultureObject halych = MBObjectManager.Instance.GetObject<CultureObject>("halych");
            CultureObject hungarian = MBObjectManager.Instance.GetObject<CultureObject>("hungarian");
            CultureObject ilkhanid = MBObjectManager.Instance.GetObject<CultureObject>("ilkhanid");
            CultureObject italian = MBObjectManager.Instance.GetObject<CultureObject>("empire");
            CultureObject latin = MBObjectManager.Instance.GetObject<CultureObject>("latin");
            CultureObject darshi = MBObjectManager.Instance.GetObject<CultureObject>("darshi");
            CultureObject cuman = MBObjectManager.Instance.GetObject<CultureObject>("cuman");
            CultureObject genoa = MBObjectManager.Instance.GetObject<CultureObject>("genoa");
            CultureObject santiago = MBObjectManager.Instance.GetObject<CultureObject>("santiago");
            CultureObject templar = MBObjectManager.Instance.GetObject<CultureObject>("templar");
            CultureObject sami = MBObjectManager.Instance.GetObject<CultureObject>("sami");
            CultureObject nizari = MBObjectManager.Instance.GetObject<CultureObject>("nizari");
            CultureObject lazarus = MBObjectManager.Instance.GetObject<CultureObject>("lazarus");
            CultureObject cathars = MBObjectManager.Instance.GetObject<CultureObject>("cathars");
            CultureObject hospitaller = MBObjectManager.Instance.GetObject<CultureObject>("hospitaller");
            CultureObject mongolian = MBObjectManager.Instance.GetObject<CultureObject>("khuzait");
            CultureObject norwegian = MBObjectManager.Instance.GetObject<CultureObject>("norwegian");
            CultureObject poland = MBObjectManager.Instance.GetObject<CultureObject>("poland");
            CultureObject portuguese = MBObjectManager.Instance.GetObject<CultureObject>("portuguese");
            CultureObject rus = MBObjectManager.Instance.GetObject<CultureObject>("rus");
            CultureObject scottish = MBObjectManager.Instance.GetObject<CultureObject>("scottish");
            CultureObject serbia = MBObjectManager.Instance.GetObject<CultureObject>("serbia");
            CultureObject sweden = MBObjectManager.Instance.GetObject<CultureObject>("sturgia");
            CultureObject teutonic = MBObjectManager.Instance.GetObject<CultureObject>("teutonic");
            CultureObject turkish = MBObjectManager.Instance.GetObject<CultureObject>("turkish");
            CultureObject wales = MBObjectManager.Instance.GetObject<CultureObject>("wales");

            this.Catholicism.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.Catholicism,
                new List<CultureObject>
                {
                    italian,
                    aragonese,
                    bohemia,
                    castile,
                    crusader,
                    danish,
                    england,
                    france,
                    gealic,
                    germanic,
                    hungarian,
                    genoa,
                    santiago,
                    templar,
                    lazarus,
                    hospitaller,
                    norwegian,
                    poland,
                    portuguese,
                    scottish,
                    sweden,
                    teutonic,
                    wales,
                }
                );

            this.ArmenianCatholicism.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.ArmenianCatholicism,
                new List<CultureObject> { armenia, crusader }
                );

            this.EasternOrthodoxy.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.EasternOrthodoxy,
                new List<CultureObject>
                {
                    latin,
                    bulgaria,
                    greek,
                    georgia,
                    halych,
                    rus,
                    serbia,

                    //non-main faiths
                    crusader
                }
                );

            this.Krstjani.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.Krstjani,
                new List<CultureObject> { bosnia }
                );

            this.Catharism.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.Catharism,
                new List<CultureObject> { cathars, france, italian }
                );

            this.SunniIslam.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.SunniIslam,
                new List<CultureObject>
                {
                    berber,
                    andalus,
                    darshi,
                    turkish,

                    //non-main faiths
                    ilkhanid,
                    mongolian,
                    nizari,
                    crusader
                }
                );

            this.ShiaIslam.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.ShiaIslam,
                new List<CultureObject>
                {
                    nizari,

                    //non-main faiths
                    berber,
                    andalus,
                    darshi,
                    turkish,
                    ilkhanid,
                    mongolian,
                    nizari,
                    crusader
                }
                );

            this.Judaism.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.Judaism,
                validCultures //all cultures
                );

            this.Tengrism.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.Tengrism,
                new List<CultureObject>
                {
                    mongolian,
                    cuman,

                    //non-main faiths
                    ilkhanid
                }
                );

            this.Buddhism.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.Buddhism,
                new List<CultureObject>
                {
                    ilkhanid,

                    //non-main faiths
                    mongolian,
                    cuman
                }
                );

            this.Romuva.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.Romuva,
                new List<CultureObject>
                {
                    baltic
                }
                );

            this.SaamiShamanism.Initialize(
                DefaultTypeInitializer<AD1259Faiths, Faith>.Instance.SaamiShamanism,
                new List<CultureObject>
                {
                    sami
                }
                );

            foreach (Religion religion in this.All)
            {
                DefaultTypeInitializer<DefaultReligions, Religion>.Instance.AddObject(religion);
            }
        }
    }
}
