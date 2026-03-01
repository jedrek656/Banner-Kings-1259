using BannerKings;
using BannerKings.Managers.Court;
using BannerKings.Managers.Court.Members;
using BannerKings.Managers.Institutions.Religions.Faiths;
using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using BannerKings1259.Religions.Faiths;
using System.Collections.Generic;
using TaleWorlds.Localization;

namespace BannerKings1259.Religions
{
    public class AD1259FaithGroups : DefaultTypeInitializer<AD1259FaithGroups, FaithGroup>
    {
        public FaithGroup CatholicGroup { get; } = new CatholicFaithGroup("WesternCatholicism");
        public FaithGroup OrthodoxGroup { get; } = new LandedPreacherGroup("EasternOrthodoxy");
        public FaithGroup ChristianHereticsGroup { get; } = new DisorganizedGroup("ChristianHeretics");
        public FaithGroup JudaismGroup { get; } = new LandedPreacherGroup("Judaism");
        public FaithGroup Islam { get; } = new AppointedGroup(DefaultTypeInitializer<DefaultCouncilPositions, CouncilMember>.Instance.Spiritual, "Islam");
        public FaithGroup MongolianFaithsGroup { get; } = new DisorganizedGroup("MongolianFaiths");
        public FaithGroup BalticPaganismsGroup { get; } = new DisorganizedGroup("BalticPaganism");

        public override IEnumerable<FaithGroup> All
        {
            get
            {
                yield return CatholicGroup;
                yield return OrthodoxGroup;
                yield return ChristianHereticsGroup;
                yield return Islam;
                yield return JudaismGroup;
                yield return MongolianFaithsGroup;
                yield return BalticPaganismsGroup;
            }
        }

        public override void Initialize()
        {
            this.CatholicGroup.Initialize(new TextObject("Catholicism", null), 
                new TextObject("After the Great Schizm in 1054... ", null));

            this.OrthodoxGroup.Initialize(new TextObject("Eastern Orthodoxy", null),
                new TextObject("After the Great Schizm in 1054... ", null));

            this.ChristianHereticsGroup.Initialize(new TextObject("Christian Heretics", null),
                new TextObject("After the Great Schizm in 1054... ", null));

            this.Islam.Initialize(new TextObject("Islam", null),
                new TextObject("After the Great Schizm in 1054... ", null));

            this.JudaismGroup.Initialize(new TextObject("Judaism", null),
                new TextObject("After the Great Schizm in 1054... ", null));

            this.MongolianFaithsGroup.Initialize(new TextObject("Mongolian beliefs", null),
                new TextObject("A set of traditional belief systems popular among Mongolian and Turkish people..."));

            this.BalticPaganismsGroup.Initialize(new TextObject("Baltic Paganism", null),
                new TextObject("The group of last pagan beliefs in Europe practiced in Lithuania and Laponia..."));

            foreach (FaithGroup faithGroup in this.All)
            {
                DefaultTypeInitializer<DefaultFaithGroups, FaithGroup>.Instance.AddObject(faithGroup);
            }
        }
    }
}
