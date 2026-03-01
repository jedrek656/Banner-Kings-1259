using BannerKings.Managers.Court;
using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Localization;

namespace BannerKings1259.Religions
{
    internal class CatholicFaithGroup: FaithGroup
    {
        public CatholicFaithGroup(string id) : base(id)
        {
        }

        public CouncilMember CouncilMember { get; set; }
        public override bool ShouldHaveLeader => true;
        public override bool IsPreacher => true;
        public override bool IsTemporal => false;
        public override bool IsPolitical => false;

        public override TextObject Explanation => new TextObject("{=!}The representative of the {GROUPS} is chosen from the Clergy.")
            .SetTextVariable("GROUPS", Name);
    }
}
