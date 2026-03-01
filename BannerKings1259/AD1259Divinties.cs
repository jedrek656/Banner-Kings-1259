using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BannerKings1259.Divinties
{
    public class AD1259Divinties : DefaultTypeInitializer<AD1259Divinties, Divinity>
    {
        //Since holy faiths are related strictly to Divinties, and to make gameplay more varied for monotheistic faiths some saints/important characters will be defined
        //Even if they are not "divinties" in this religion


        //Abrahamic God
        public Divinity God { get; } = new Divinity("God");
        //Christian Saints
        public Divinity SaintMary { get; } = new Divinity("SaintMary");
        //Muslim
        public Divinity Muhammad { get; } = new Divinity("Muhammad");
        //Buddhist
        public Divinity Buddha { get; } = new Divinity("Buddha");
        //Tengrism
        public Divinity Tengri { get; } = new Divinity("Tengri");
        public Divinity Umay { get; } = new Divinity("Umay");
        public Divinity Kayra { get; } = new Divinity("Kayra");
        public Divinity Ulgen { get; } = new Divinity("Ulgen");
        public Divinity Mergen { get; } = new Divinity("Mergen");
        public Divinity Erlik { get; } = new Divinity("Erlik");
        public Divinity AyDede { get; } = new Divinity("AyDede");
        public Divinity Natigai { get; } = new Divinity("Natigai");
        //Romuva
        public Divinity Dievas { get; } = new Divinity("Dievas");
        public Divinity Senelis { get; } = new Divinity("Senelis");
        public Divinity Praamzius { get; } = new Divinity("Praamzius");
        public Divinity Ausrine { get; } = new Divinity("Ausrine");
        public Divinity Dalia { get; } = new Divinity("Dalia");
        //...
        //Saami
        public Divinity Beaivi { get; } = new Divinity("Beaivi");
        //...

        public override IEnumerable<Divinity> All
        {
            get
            {
                yield return God;
                yield return SaintMary;
                yield return Buddha;
                yield return Tengri;
                yield return Dievas;
                yield return Beaivi;
            }
        }

        public override void Initialize()
        {
            God.Initialize(new TextObject("{=!}God"),
               new TextObject("{=!}God... ."),
               new TextObject("{=!}(Effect...)"),
               new TextObject("{=!}Jahwe/Allah"),
               500,
               new TextObject(),
               new TextObject(),
               Enumerable.First<Settlement>(Settlement.All, (Settlement x) => x.StringId == "town_jerusalem"));

            SaintMary.Initialize(new TextObject("{=!}Saint Mary"),
               new TextObject("{=!}Description... ."),
               new TextObject("{=!}(Effect...)"),
               new TextObject("{=!}Mother of Jesus"),
               500,
               new TextObject(),
               new TextObject(),
               Enumerable.First<Settlement>(Settlement.All, (Settlement x) => x.StringId == Helpers.Helpers.getRomeCityID()));

            Muhammad.Initialize(new TextObject("{=!}Muhammad"),
               new TextObject("{=!}Description... ."),
               new TextObject("{=!}(Effect...)"),
               new TextObject("{=!}Messenger of God"),
               500,
               new TextObject(),
               new TextObject(),
               Enumerable.First<Settlement>(Settlement.All, (Settlement x) => x.StringId == "town_medina"));

            Buddha.Initialize(new TextObject("{=!}Buddha"),
               new TextObject("{=!}Description... ."),
               new TextObject("{=!}(Effect...)"),
               new TextObject("{=!}Awaked One"),
               500,
               new TextObject(),
               new TextObject());

            Tengri.Initialize(new TextObject("{=!}Tengri"),
               new TextObject("{=!}Description... ."),
               new TextObject("{=!}(Effect...)"),
               new TextObject("{=!}Blue heaven"),
               500,
               new TextObject(),
               new TextObject());

            Dievas.Initialize(new TextObject("{=!}Dievas"),
               new TextObject("{=!}Description... ."),
               new TextObject("{=!}(Effect...)"),
               new TextObject("{=!}Sky-father"),
               500,
               new TextObject(),
               new TextObject());

            Beaivi.Initialize(new TextObject("{=!}Beaivi"),
               new TextObject("{=!}Description... ."),
               new TextObject("{=!}(Effect...)"),
               new TextObject("{=!}Piäiváž"),
               500,
               new TextObject(),
               new TextObject());

            foreach (Divinity divinity in this.All)
            {
                DefaultTypeInitializer<DefaultDivinities, Divinity>.Instance.AddObject(divinity);
            }
        }
    }
}
