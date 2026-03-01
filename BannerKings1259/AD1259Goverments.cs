using BannerKings;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Kingdoms.Policies;
using BannerKings.Managers.Titles.Governments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;

namespace BannerKings1259.Goverments
{
    internal class AD1259Goverments: DefaultTypeInitializer<AD1259Goverments, Government>
    {
        public Government LifelongRepublic { get; } = new Government("LifelongRepublic");

        public override IEnumerable<Government> All
        {
            get
            {
                yield return LifelongRepublic;
            }
        }

        public override void Initialize()
        {
            

            LifelongRepublic.Initialize(new TextObject("Lifelong Republic"),
                new TextObject("Lieflong Republics unlike normal republics did not held every-year elections but rather chosen leaders for lifetime. However just as republic they had higher levels of egalitharian values."),
                new TextObject("{=onDTTX11}- Settlement production quality +10%{newline}- Settlement loyalty +1{newline}- Settlement mercantilism +50%"),
                0.5f,
                -0.5f,
                0.6f,
                0.8f,
                new List<PolicyObject>()
                {
                    DefaultPolicies.SacredMajesty,
                    DefaultPolicies.CrownDuty,
                    DefaultPolicies.ImperialTowns,
                    DefaultPolicies.RoyalCommissions,
                    DefaultPolicies.RoyalGuard,
                    DefaultPolicies.RoyalPrivilege,
                    DefaultPolicies.CastleCharters,
                    DefaultPolicies.StateMonopolies,
                    DefaultPolicies.DebasementOfTheCurrency,
                    BKPolicies.Instance.LimitedArmyPrivilege
                },
                new List<Succession>()
                {
                    DefaultSuccessions.Instance.Republic,
                    DefaultSuccessions.Instance.Dictatorship
                });

            

            

            foreach (Government gov in this.All)
            {
                DefaultTypeInitializer<DefaultGovernments, Government>.Instance.AddObject(gov);
            }
        }
    }
}
