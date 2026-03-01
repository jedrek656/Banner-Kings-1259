using BannerKings.Managers.Institutions.Religions.Faiths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Localization;

namespace BannerKings1259.Religions.Faiths
{
    internal class CatharFaith: DualisticFaith
    {
        public override Settlement FaithSeat
        {
            get
            {
                //return Enumerable.First<Settlement>(Settlement.All, (Settlement x) => x.StringId == Helpers.Helpers.getRomeCityID());
                return null;
            }
        }

        public override Banner GetBanner()
        {
            return new Banner("11.145.145.1836.1836.768.768.0.0.0.503.7.142.0.0.764.763.0.0.0.505.7.40.346.60.764.763.0.0.0.505.7.40.450.60.764.763.0.0.90.504.7.40.112.225.607.703.0.1.0.504.7.40.112.225.607.823.0.0.180.504.7.40.112.225.922.703.0.1.0.504.7.40.112.225.922.823.0.0.180.504.7.40.112.225.824.553.0.1.-91.504.7.40.112.225.704.553.0.0.89.504.7.40.112.225.824.973.0.1.-91.504.7.40.112.225.704.973.0.0.89.427.7.40.507.187.809.763.0.0.270.427.7.40.507.187.719.763.0.1.90.427.7.40.384.187.764.711.0.0.0.427.7.40.384.187.764.816.0.1.180.506.145.40.120.133.562.697.0.1.153.506.145.40.120.133.562.829.0.0.26.506.145.40.120.133.966.829.0.1.333.506.145.40.120.133.965.697.0.0.206.506.145.40.120.133.836.1014.0.0.106.506.145.40.120.133.696.1017.0.1.253.506.145.40.120.133.692.510.0.0.-74.506.145.40.120.133.836.510.0.1.73.503.116.116.48.48.565.763.1.0.117.503.7.116.45.45.565.763.1.0.117.503.116.116.48.48.766.512.1.0.117.503.7.116.45.45.766.512.1.0.117.503.116.116.48.48.764.1015.1.0.117.503.7.116.45.45.764.1015.1.0.117.503.116.116.48.48.963.763.1.0.117.503.7.116.45.45.963.763.1.0.117.503.116.116.48.48.925.643.1.0.117.503.7.116.45.45.925.643.1.0.117.503.116.116.48.48.925.883.1.0.117.503.7.116.45.45.925.883.1.0.117.503.116.116.48.48.603.883.1.0.117.503.7.116.45.45.603.883.1.0.117.503.116.116.48.48.603.643.1.0.117.503.7.116.45.45.603.643.1.0.117.503.116.116.48.48.644.553.1.0.117.503.7.116.45.45.644.553.1.0.117.503.116.116.48.48.884.553.1.0.117.503.7.116.45.45.884.553.1.0.117.503.116.116.48.48.884.975.1.0.117.503.7.116.45.45.884.975.1.0.117.503.116.116.48.48.646.975.1.0.117.503.7.116.45.45.646.975.1.0.117.504.142.40.48.48.922.763.0.0.270.504.142.40.48.48.607.763.0.1.90.504.142.40.56.48.764.553.0.0.0.504.142.40.56.48.764.973.0.1.180.505.142.40.22.337.764.763.0.0.270.505.142.40.22.337.764.763.0.0.274.505.142.40.22.457.764.763.0.0.0.505.142.40.22.465.764.763.0.0.4.505.142.40.22.465.764.763.0.0.-4.505.142.40.22.337.764.763.0.0.266");
        }

        public override TextObject GetBlessingAction()
        {
            return new TextObject("I would like to pray.", null);
        }

        public override TextObject GetBlessingActionName()
        {
            return new TextObject("pray to.", null);
        }

        public override TextObject GetBlessingConfirmQuestion()
        {
            return new TextObject("Are you certain?", null);
        }

        public override TextObject GetBlessingQuestion()
        {
            return new TextObject("Would you pray?", null);
        }

        public override TextObject GetBlessingQuickInformation()
        {
            return new TextObject("{HERO} has prayed to {DIVINITY}.", null);
        }

        public override TextObject GetClergyForbiddenAnswer(int rank)
        {
            return new TextObject("Forbidden in this faith is... .", null);
        }

        public override TextObject GetClergyForbiddenAnswerLast(int rank)
        {
            return new TextObject("Those who disobey the faith... .", null);
        }

        public override TextObject GetClergyGreeting(int rank)
        {
            return new TextObject("God bless you.", null);
        }

        public override TextObject GetClergyGreetingInducted(int rank)
        {
            return new TextObject("God bless you.", null);
        }

        public override TextObject GetClergyInduction(int rank)
        {
            return new TextObject("I baptize you in the name of the Father, and of the Son, and of the Holy Spirit.", null);
        }

        public override TextObject GetClergyInductionLast(int rank)
        {
            return new TextObject("May the faith you just accepted bring you to harmony.", null);
        }

        public override TextObject GetClergyPreachingAnswer(int rank)
        {
            return new TextObject("I preach this faith.", null);
        }

        public override TextObject GetClergyPreachingAnswerLast(int rank)
        {
            return new TextObject("To honor Him... .", null);
        }

        public override TextObject GetClergyProveFaith(int rank)
        {
            return new TextObject("Prove faith by... .", null);
        }

        public override TextObject GetClergyProveFaithLast(int rank)
        {
            return new TextObject("The faithful live is the one that... .", null);
        }

        public override TextObject GetCultsDescription()
        {
            return new TextObject("Gods", null);
        }

        public override TextObject GetDescriptionHint()
        {
            return new TextObject("This religion is centered on... .", null);
        }

        public override TextObject GetFaithDescription()
        {
            return new TextObject("The religion of the Rhoynar is one centered, based on faith in... .", null);
        }

        public override TextObject GetFaithName()
        {
            return new TextObject("Catharism", null);
        }

        public override string GetId()
        {
            return "catharism";
        }

        public override int GetIdealRank(Settlement settlement)
        {
            return 1;
            /*bool flag = settlement.StringId == "town_V6";
            int result;
            if (flag)
            {
                result = 2;
            }
            else
            {
                result = 1;
            }
            return result;*/
        }

        public override ValueTuple<bool, TextObject> GetInductionAllowed(Hero hero, int rank)
        {
            bool possible = true;
            TextObject text = new TextObject("You will be converted", null);
            bool flag = !this.IsCultureNaturalFaith(hero.Culture) && hero.Culture.StringId != "aserai";
            bool flag2 = flag;
            if (flag2)
            {
                possible = false;
                text = this.GetInductionExplanationText();
            }
            return new ValueTuple<bool, TextObject>(possible, text);
        }

        public override TextObject GetInductionExplanationText()
        {
            return new TextObject("As descendants of the Rhoynar, only Dornish are accepted.", null);
        }

        public override int GetMaxClergyRank()
        {
            return 1;
            //return 2;
        }

        public override TextObject GetRankTitle(int rank)
        {
            return new TextObject("{!=}Preacher", null);
        }

        public override TextObject GetZealotsGroupName()
        {
            return new TextObject("", null);
        }

        public override bool IsCultureNaturalFaith(CultureObject culture)
        {
            return culture.StringId == "cathar";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return this.IsCultureNaturalFaith(hero.Culture);
        }
    }
}
