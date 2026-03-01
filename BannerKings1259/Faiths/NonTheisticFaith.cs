using BannerKings.Managers.Institutions.Religions.Faiths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Localization;

namespace BannerKings1259.Religions.Faiths
{
    public abstract class NonTheisticFaith: Faith
    {
        public override TextObject GetFaithTypeName() => new TextObject("{=!}Non Theism");
        public override TextObject GetFaithTypeExplanation() => new TextObject("{=!}Non-theists does not worship any particular God or Divinity but rather focus on philosophy, spiritual liberation and ethics.");

        public override float BlessingCostFactor => 0.8f;
        public override float FaithStrengthFactor => 0.6f;
        public override float JoinSocietyCost => 0.4f;
        public override float VirtueFactor => 0.8f;
        public override float ConversionCost => 1f;
    }
}
