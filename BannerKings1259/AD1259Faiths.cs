using BannerKings;
using BannerKings.Behaviours.Feasts;
using BannerKings.CampaignContent.Traits;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Doctrines;
using BannerKings.Managers.Institutions.Religions.Doctrines.Marriage;
using BannerKings.Managers.Institutions.Religions.Doctrines.War;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using BannerKings.Managers.Institutions.Religions.Faiths.Rites;
using BannerKings.Managers.Institutions.Religions.Faiths.Societies;
using BannerKings1259.Divinties;
using BannerKings1259.Faiths;
using BannerKings1259.Religions.Faiths;
using System.Collections.Generic;
using TaleWorlds.CampaignSystem.CharacterDevelopment;

namespace BannerKings1259.Religions
{
    public class AD1259Faiths : DefaultTypeInitializer<AD1259Faiths, Faith>
    {
        public MonotheisticFaith Catholicism { get; private set; } = new CatholicFaith();
        public MonotheisticFaith ArmenianCatholicism { get; private set; } = new ArmenianCatholicFaith();
        public MonotheisticFaith EasternOrthodoxy { get; private set; } = new OrthodoxFaith();
        public MonotheisticFaith Krstjani { get; private set; } = new KrstjaniFaith();
        public DualisticFaith Catharism { get; private set; } = new CatharFaith();
        public MonotheisticFaith SunniIslam {  get; private set; } = new SunnicFaith();
        public MonotheisticFaith ShiaIslam { get; private set; } = new ShiaFaith();
        public MonotheisticFaith Judaism { get; private set; } = new JudaismFaith();
        public HenotheisticFaith Tengrism { get; private set; } = new TengrismFaith();
        public NonTheisticFaith Buddhism { get; private set; } = new BuddhistFaith();
        public PolytheisticFaith Romuva {  get; private set; } = new RomuvaFaith();
        public PolytheisticFaith SaamiShamanism { get; private set; } = new SaamiShamanismFaith();

        public override IEnumerable<Faith> All
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
                yield return Judaism;
                yield return Tengrism;
                yield return Buddhism;
                yield return Romuva;
                yield return SaamiShamanism;
            }
        }

        public override void Initialize()
        {
            this.Catholicism.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>
                {
                    DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.SaintMary
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, true },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just, true },
                    { DefaultTraits.Honor, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.CatholicGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.ArmenianCatholicism.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>
                {
                    DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.SaintMary
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, true },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Diligent, true },
                    { DefaultTraits.Valor, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.CatholicGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.EasternOrthodoxy.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>
                {
                    DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.SaintMary
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble, true },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just, true },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.OrthodoxGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.RenovatioImperi,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.Krstjani.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>
                {
                    DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.SaintMary
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, false },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble, true },
                    { DefaultTraits.Mercy, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.ChristianHereticsGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.Catharism.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>
                {
                    DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.SaintMary
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious, false },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble, true },
                    { DefaultTraits.Mercy, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.ChristianHereticsGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pacifism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.SunniIslam.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>
                {
                    DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.Muhammad
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, true },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just, true },
                    { DefaultTraits.Valor, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.Islam,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Childbirth,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Polygamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.ShiaIslam.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>
                {
                    DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.Muhammad
                },
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, true },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just, true },
                    { DefaultTraits.Honor, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.Islam,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.HeathenTax,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Childbirth,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Polygamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.Judaism.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.God,
                new List<Divinity>(),
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Diligent, true },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Just, true },
                    { DefaultTraits.Calculating, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.JudaismGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Legalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Literalism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Childbirth,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Monogamy,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.Tengrism.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.Tengri,
                new List<Divinity>(),
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious, true },
                    { DefaultTraits.Valor, true },
                    { DefaultTraits.Mercy, false }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.MongolianFaithsGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.AncestorWorship,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Shamanism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Animism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Reavers,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Sacrifice,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.OpenConcubinage,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.OpenWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.Buddhism.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.Buddha,
                new List<Divinity>(),
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, false },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble, true },
                    { DefaultTraits.Mercy, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.MongolianFaithsGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Esotericism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pacifism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Astrology,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Tolerant,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.OpenConcubinage,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.Romuva.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.Dievas,
                new List<Divinity>(),
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Zealous, true },
                    { DefaultTraits.Valor, true },
                    { DefaultTraits.Honor, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.BalticPaganismsGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.AncestorWorship,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Animism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Sacrifice,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Warlike,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.CommunalFaith,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.Reclamation,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            this.SaamiShamanism.Initialize(
                DefaultTypeInitializer<AD1259Divinties, Divinity>.Instance.Beaivi,
                new List<Divinity>(),
                new Dictionary<TraitObject, bool>
                {
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Ambitious, false },
                    { DefaultTypeInitializer<BKTraits, TraitObject>.Instance.Humble, true },
                    { DefaultTraits.Mercy, true }
                },
                DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>.Instance.BalticPaganismsGroup,
                new List<Doctrine>
                {
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.AncestorWorship,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Animism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Shamanism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pacifism,
                    DefaultTypeInitializer<DefaultDoctrines, Doctrine>.Instance.Pastoralism,
                },
                DefaultTypeInitializer<DefaultMarriageDoctrines, MarriageDoctrine>.Instance.Concubinage,
                DefaultTypeInitializer<DefaultWarDoctrines, WarDoctrine>.Instance.NoWarfare,
                new List<Rite>(),
                new List<Society>(),
                Feast.FeastType.Normal);

            Catholicism.AddStance(SunniIslam, FaithStance.Hostile);
            Catholicism.AddStance(ShiaIslam, FaithStance.Hostile);
            Catholicism.AddStance(Catharism, FaithStance.Hostile);

            EasternOrthodoxy.AddStance(Catharism, FaithStance.Hostile);

            SunniIslam.AddStance(Catholicism, FaithStance.Hostile);
            ShiaIslam.AddStance(Catholicism, FaithStance.Hostile);

            Krstjani.AddStance(Catharism, FaithStance.Tolerated);

            Catharism.AddStance(Catholicism, FaithStance.Hostile);
            Catharism.AddStance(EasternOrthodoxy, FaithStance.Hostile);
            Catharism.AddStance(Krstjani, FaithStance.Tolerated);

            foreach (Faith faith in this.All)
            {
                DefaultTypeInitializer<DefaultFaiths, Faith>.Instance.AddObject(faith);
            }
        }
    }
}
