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
    internal class BuddhistFaith: NonTheisticFaith
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
            return new Banner("11.28.19.1836.1836.768.788.1.0.-30.10273.92.126.440.440.764.764.0.1.0");
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
            return new TextObject("Buddhism", null);
        }

        public override string GetId()
        {
            return "buddhism";
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
            return culture.StringId == "ilkhanid";
        }

        public override bool IsHeroNaturalFaith(Hero hero)
        {
            return this.IsCultureNaturalFaith(hero.Culture);
        }
    }
}
