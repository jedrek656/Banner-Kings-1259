using BannerKings;
using BannerKings.Actions;
using BannerKings.Behaviours;
using BannerKings.Behaviours.Diplomacy.Wars;
using BannerKings.Behaviours.Shipping;
using BannerKings.Managers;
using BannerKings.Managers.CampaignStart;
using BannerKings.Managers.Court;
using BannerKings.Managers.Cultures;
using BannerKings.Managers.Education.Languages;
using BannerKings.Managers.Innovations;
using BannerKings.Managers.Innovations.Eras;
using BannerKings.Managers.Institutions.Religions;
using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using BannerKings.Managers.Kingdoms.Policies;
using BannerKings.Managers.Kingdoms.Succession;
using BannerKings.Managers.Populations;
using BannerKings.Managers.Shipping;
using BannerKings.Managers.Skills;
using BannerKings.Managers.Titles;
using BannerKings.Managers.Titles.Governments;
using BannerKings.Models.Vanilla;
using BannerKings.UI;
using BannerKings.UI.CampaignStart;
using BannerKings.UI.Management;
using BannerKings.Utils;
using BannerKings.Utils.Extensions;
using BannerKings1259.Goverments;
using BannerKings1259.Religions;
using Bannerlord.Harmony;
using HarmonyLib;
using Helpers;
using StoryMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.Actions;
using TaleWorlds.CampaignSystem.CampaignBehaviors;
using TaleWorlds.CampaignSystem.CharacterDevelopment;
using TaleWorlds.CampaignSystem.Conversation;
using TaleWorlds.CampaignSystem.Election;
using TaleWorlds.CampaignSystem.Extensions;
using TaleWorlds.CampaignSystem.GameState;
using TaleWorlds.CampaignSystem.MapEvents;
using TaleWorlds.CampaignSystem.Party;
using TaleWorlds.CampaignSystem.Party.PartyComponents;
using TaleWorlds.CampaignSystem.Roster;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Core;
using TaleWorlds.Core.ViewModelCollection.Information;
using TaleWorlds.Library;
using TaleWorlds.Localization;

namespace BannerKings1259.Patches
{
    //those base games instances need to be initialized but not assigned to any culture/towns etc.
    [HarmonyPatch(typeof(DefaultLanguages), "Initialize")]
    internal class DefaultLanguagesInitializePatch
    {
        public static bool Prefix(DefaultLanguages __instance)
        {
            MBReadOnlyList<CultureObject> cultures = Game.Current.ObjectManager.GetObjectTypeList<CultureObject>();
            Language battanian = __instance.Battanian;
            TextObject textObject = new TextObject("{=tRp08jyH}Battanian", null);
            TextObject textObject2 = new TextObject("{=hNK8XTow}The language of the Battanian peoples has long since been a cultural divide between Battanians and other kingdoms in the continent. Given that Palaic, its sister language and culture, has mostly been erased by Imperials, the Battanian language is almost completely unintelligible to all other cultures present in Calradia. However, with the increased presence of Calradian as the lingua franca of trade, Battanians have slowly adopted some Imperial vocabulary. The language is still somewhat similar to Vakken, another natural culture of the continent, though recently the Vakken culture has mostly been replaced by Sturgians.", null);
            List<CultureObject> list = new List<CultureObject>();
            battanian.Initialize(textObject, textObject2, list, __instance.GetIntelligibles(__instance.Battanian));
            Language sturgian = __instance.Sturgian;
            TextObject textObject3 = new TextObject("{=VtNL32g2}Sturgian", null);
            TextObject textObject4 = new TextObject("{=QT3S6XkQ}Natural to the northern ends of Calradia, the Sturgians have an ancient linguistic tradition. Though __instance tradition has been recently shaken by the large mixing of nords, the Sturgian culture itself is native to the continent, as well as it's sister culture, Vakken, with which the Sturgian language still finds similarities.", null);
            List<CultureObject> list2 = new List<CultureObject>();
            sturgian.Initialize(textObject3, textObject4, list2, __instance.GetIntelligibles(__instance.Sturgian));
            Language khuzait = __instance.Khuzait;
            TextObject textObject5 = new TextObject("{=ZdFBNgoJ}Khuzait", null);
            TextObject textObject6 = new TextObject("{=rYVgj513}The langauge of the steppe is often described by foreigners as curt, but effective. Due to the near absence of scholarly research in the Khuzait culture, it often lacks terms for technical, or more abstract concepts, and as such it is certain those will be adopted from the Imperial language.", null);
            List<CultureObject> list3 = new List<CultureObject>();
            khuzait.Initialize(textObject5, textObject6, list3, __instance.GetIntelligibles(__instance.Khuzait));
            Language vlandic = __instance.Vlandic;
            TextObject textObject7 = new TextObject("{=6FGQ31TM}Vlandic", null);
            TextObject textObject8 = new TextObject("{=!}", null);
            List<CultureObject> list4 = new List<CultureObject>();
            vlandic.Initialize(textObject7, textObject8, list4, __instance.GetIntelligibles(__instance.Vlandic));
            Language calradian = __instance.Calradian;
            TextObject textObject9 = new TextObject("{=NWqkTdMt}Calradian", null);
            TextObject textObject10 = new TextObject("{=GmqBFSgN}The Imperial language of the Calradian empire. Though scholars have made efforts into keeping the language pure, centuries of contact with local cultures have made Calradian adopt small quantities of local vocabularies. Being a language of prestige, Calradian vocabulary are also often adopted by foreign languages, due to it's usefulness in the continent as a Lingua Franca, often used by traders, nobles during their education or peasants looking for a better life within the Empire.", null);
            List<CultureObject> list5 = new List<CultureObject>();
            calradian.Initialize(textObject9, textObject10, list5, __instance.GetIntelligibles(__instance.Calradian));
            Language aseran = __instance.Aseran;
            TextObject textObject11 = new TextObject("{=!}Nahasawi", null);
            TextObject textObject12 = new TextObject("{=gM4s1KQf}Although the Aserai peoples speak a multitude of dialects, scattered across the oases, springs and coasts of the Nahasa, a distinct tradition of literalism and poety has established a common variation that has been embraced by the higher Aserai classes.", null);
            List<CultureObject> list6 = new List<CultureObject>();
            aseran.Initialize(textObject11, textObject12, list6, __instance.GetIntelligibles(__instance.Aseran));
            Language vakken = __instance.Vakken;
            TextObject textObject13 = new TextObject("{=brxz2SmN}Vakken", null);
            TextObject textObject14 = new TextObject("{=bXUwFrCF}The Vakken, sometimes called 'children of the forest', are a group native to northern Calradia. Vakken and Sturgian cultures have ancient connections, as both have lived and traded for centuries before the Imperials arrived in the continent. However, with the prevailment of the Sturgia kingdom and culture, the Vakken tongue and tradition is being increasingly forgotten about in the north.", null);
            List<CultureObject> list7 = new List<CultureObject>();
            vakken.Initialize(textObject13, textObject14, list7, __instance.GetIntelligibles(__instance.Vakken));
            return false;
        }
    }

    [HarmonyPatch(typeof(DefaultShippingLanes), "Initialize")]
    internal class DefaultShippingLangesInitializePatch
    {
        // Token: 0x060003CA RID: 970 RVA: 0x0000EB38 File Offset: 0x0000CD38
        public static bool Prefix(DefaultShippingLanes __instance)
        {
            __instance.Laconis.Initialize(new TextObject("{=ZJBYtrAB}Laconian Shipping Network", null), new TextObject("", null), new List<Settlement>(), false, null);
            __instance.Western.Initialize(new TextObject("{=tySxydya}Western Sea Network", null), new TextObject("", null), new List<Settlement>(), false, null);
            __instance.Junme.Initialize(new TextObject("{=FGXR8tdb}Junme Trade Network", null), new TextObject("", null), new List<Settlement>(), false, null);
            __instance.Perassic.Initialize(new TextObject("{=TFoGRBnG}Perassic Trade Network", null), new TextObject("", null), new List<Settlement>(), false, null);
            return false;
        }
    }

    
    //initialized to override calrardian specific names, and change some succesions to more historical counterparts
    [HarmonyPatch(typeof(DefaultSuccessions), "Initialize")]
    internal class DefaultSuccesionsInitializePatch
    {
        public static void Postfix(DefaultSuccessions __instance)
        {
            __instance.AseraiElective.Initialize(new TextObject("{=!}Oligarchic Elective"),
               new TextObject("{=!}Oligarchic nations are most interested in the economic prosperity of the realm. A strong leader, they say, is one both brave, so they may defeat their enemies, and generous, so they may be loved by those under their protection."),
               true,
               -0.7f,
               1f,
               -0.2f,
               new TextObject("{=eFPsZg5e}- Heir of current ruler\n- Any Full Peerage clan leader"),
               new TextObject("{=VodLiu3P}++ Skills\n++ Welth\n++ Military power\n+ Clan tier\n+ Inheritance score (for clan inheritors)"),
               (Hero currentLeader, FeudalTitle title) =>
               {
                   HashSet<Hero> result = new HashSet<Hero>(3);
                   foreach (Hero hero in BannerKingsConfig.Instance.TitleModel.GetInheritanceCandidates(currentLeader).Take(1))
                   {
                       result.Add(hero);
                   }

                   foreach (Clan clan in currentLeader.Clan.Kingdom.Clans)
                   {
                       if (clan.IsUnderMercenaryService) continue;

                       CouncilData council = BannerKingsConfig.Instance.CourtManager.GetCouncil(clan);
                       if (council.Peerage != null && council.Peerage.IsFullPeerage)
                       {
                           result.Add(clan.Leader);
                       }
                   }

                   if (result.Contains(currentLeader))
                       result.Remove(currentLeader);

                   return result;
               },
               (Hero currentLeader, Hero candidate, FeudalTitle title, bool explanations) =>
               {
                   ExplainedNumber result = new ExplainedNumber(0f, explanations);

                   result.Add(candidate.Clan.Gold / 200f, new TextObject("{=hnM1tYvQ}Gold"));

                   result.Add(candidate.GetSkillValue(DefaultSkills.Leadership) / 2f, DefaultSkills.Leadership.Name);
                   result.Add(candidate.GetSkillValue(DefaultSkills.Tactics) / 2f, DefaultSkills.Tactics.Name);
                   result.Add(candidate.GetSkillValue(DefaultSkills.Charm) / 2f, DefaultSkills.Charm.Name);

                   result.Add(candidate.Clan.Tier * 25f, GameTexts.FindText("str_clan_tier_bonus"));

                   if (candidate.MapFaction != currentLeader.MapFaction)
                       result.AddFactor(-0.5f, new TextObject("{=!}Foreign candidate"));
                   return result;
               });

            __instance.BattanianElective.Initialize(new TextObject("{=XNxbaSa8}Elective Monarchy"),
                new TextObject("{=rtGNUhGU} In Elective Monarchy the ruler does not automatically inherit the right to throne but rather is chosen from possible candidates. Being part of rulling dynasty still gives a minor bonus as some of the Noble clans believe it leads to more stable goverment."),
                true,
                -0.4f,
                1f,
                0.2f,
                new TextObject("{=Ei6ahKw3}- Inheritance candidates of current ruler\n- Any clan leader of clan tier 3 or higher"),
                new TextObject("{=ydo55teN}+++ Clan tier\n++ Skills\n+ Inheritance score (for clan inheritors)\n+ Military power"),
                (Hero currentLeader, FeudalTitle title) =>
                {
                    HashSet<Hero> result = new HashSet<Hero>(3);
                    foreach (Hero hero in BannerKingsConfig.Instance.TitleModel.GetInheritanceCandidates(currentLeader))
                    {
                        result.Add(hero);
                    }

                    foreach (Clan clan in currentLeader.Clan.Kingdom.Clans)
                    {
                        if (clan.IsUnderMercenaryService || clan.Tier < 3) continue;

                        FeudalTitle highestTitle = BannerKingsConfig.Instance.TitleManager.GetHighestTitle(clan.Leader);
                        if (highestTitle != null && highestTitle.TitleType <= TitleType.County)
                        {
                            result.Add(clan.Leader);
                        }
                    }

                    if (result.Contains(currentLeader))
                        result.Remove(currentLeader);

                    return result;
                },
                (Hero currentLeader, Hero candidate, FeudalTitle title, bool explanations) =>
                {
                    ExplainedNumber result = new ExplainedNumber(0f, explanations);

                    if (BannerKingsConfig.Instance.TitleModel.GetInheritanceCandidates(currentLeader).Contains(candidate))
                    {
                        result.Add(BannerKingsConfig.Instance.TitleModel.GetInheritanceHeirScore(currentLeader,
                            candidate,
                            title.Contract,
                            explanations).ResultNumber * 0.5f, new TextObject("{=mL5FFwSG}{CLAN} inheritor")
                            .SetTextVariable("CLAN", currentLeader.Clan.Name));
                    }

                    result.Add(TaleWorlds.CampaignSystem.Campaign.Current.Models.DiplomacyModel.GetClanStrength(candidate.Clan) / 600f,
                        new TextObject("{=dnq6qC7y}Military power"));

                    result.Add(candidate.GetSkillValue(DefaultSkills.Leadership) / 2f, DefaultSkills.Leadership.Name);
                    result.Add(candidate.GetSkillValue(DefaultSkills.Tactics) / 2f, DefaultSkills.Tactics.Name);
                    result.Add(candidate.GetSkillValue(DefaultSkills.Charm) / 2f, DefaultSkills.Charm.Name);

                    result.Add(candidate.Clan.Tier * 75f, GameTexts.FindText("str_clan_tier_bonus"));
                    if (candidate.MapFaction != currentLeader.MapFaction)
                        result.AddFactor(-0.5f, new TextObject("{=!}Foreign candidate"));
                    return result;
                });


            __instance.WilundingElective.Initialize(new TextObject("{=XNxbaSa8}Electio Viritim"),
                new TextObject("{=rtGNUhGU}Electio viritim known as \"Wolna Elekcja\" was a form of succesiion originating from The Commonwealth. It was simillar to elective monarchy but was not limited to in-kingdom clans only. It caused problems with outer influence."),
                true,
                -0.6f,
                1f,
                0.4f,
                new TextObject("{=Ei6ahKw3}- Inheritance candidates of current ruler\n- Any clan leader of clan tier 3 or higher"),
                new TextObject("{=ydo55teN}+++ Clan tier\n++ Skills\n+ Military power"),
                (Hero currentLeader, FeudalTitle title) =>
                {
                    HashSet<Hero> result = new HashSet<Hero>(3);
                    foreach (Hero hero in BannerKingsConfig.Instance.TitleModel.GetInheritanceCandidates(currentLeader))
                    {
                        result.Add(hero);
                    }

                    foreach (Clan clan in currentLeader.Clan.Kingdom.Clans)
                    {
                        if (clan.IsUnderMercenaryService || clan.Tier < 3) continue;

                        FeudalTitle highestTitle = BannerKingsConfig.Instance.TitleManager.GetHighestTitle(clan.Leader);
                        if (highestTitle != null && highestTitle.TitleType <= TitleType.County)
                        {
                            result.Add(clan.Leader);
                        }
                    }

                    if (result.Contains(currentLeader))
                        result.Remove(currentLeader);

                    return result;
                },
                (Hero currentLeader, Hero candidate, FeudalTitle title, bool explanations) =>
                {
                    ExplainedNumber result = new ExplainedNumber(0f, explanations);

                    result.Add(TaleWorlds.CampaignSystem.Campaign.Current.Models.DiplomacyModel.GetClanStrength(candidate.Clan) / 600f,
                        new TextObject("{=dnq6qC7y}Military power"));

                    result.Add(candidate.GetSkillValue(DefaultSkills.Leadership) / 2f, DefaultSkills.Leadership.Name);
                    result.Add(candidate.GetSkillValue(DefaultSkills.Tactics) / 2f, DefaultSkills.Tactics.Name);
                    result.Add(candidate.GetSkillValue(DefaultSkills.Charm) / 1.5f, DefaultSkills.Charm.Name);

                    result.Add(candidate.Clan.Tier * 75f, GameTexts.FindText("str_clan_tier_bonus"));
                    return result;
                });

            __instance.TribalElective.Initialize(new TextObject("{=7FEVXuj2}Tribal Elective"),
                new TextObject("{=7FEVXuj2}Tribal Elective succession describes a generalized form of succession for communities where proper administration systems have not yet emerged. Such practices often care little for dynastic inheritance and none for legal trivialities such as claims. Instead, strong competent leaders are respected, specially those with renowned names, for these are the types of rulers that can rally together rivaling tribes that would otherwise be destroying each other."),
                true,
                -0.4f,
                1f,
                0.2f,
                new TextObject("{=Xfwnn1HM}-Inheritance candidates of current ruler\n- Title claimants\n- Anyone with title of count or higher and clan tier 5 or higher"),
                new TextObject("{=VodLiu3P}++ Skills\n++ Military power\n+ Clan tier\n+ Inheritance score (for clan inheritors)"),
                (Hero currentLeader, FeudalTitle title) =>
                {
                    HashSet<Hero> result = new HashSet<Hero>(3);
                    foreach (Hero hero in BannerKingsConfig.Instance.TitleModel.GetInheritanceCandidates(currentLeader))
                    {
                        result.Add(hero);
                    }

                    foreach (var claimant in title.Claims)
                    {
                        Hero hero = claimant.Key;
                        if (claimant.Value != ClaimType.Ongoing && claimant.Value != ClaimType.None)
                        {
                            if (hero.IsClanLeader())
                            {
                                result.Add(hero);
                            }
                        }
                    }

                    foreach (Clan clan in currentLeader.Clan.Kingdom.Clans)
                    {
                        if (clan.IsUnderMercenaryService) continue;

                        FeudalTitle highestTitle = BannerKingsConfig.Instance.TitleManager.GetHighestTitle(clan.Leader);
                        if (highestTitle != null && highestTitle.TitleType <= TitleType.County)
                        {
                            result.Add(clan.Leader);
                        }
                    }

                    if (result.Contains(currentLeader))
                        result.Remove(currentLeader);

                    return result;
                },
                (Hero currentLeader, Hero candidate, FeudalTitle title, bool explanations) =>
                {
                    ExplainedNumber result = new ExplainedNumber(0f, explanations);

                    if (BannerKingsConfig.Instance.TitleModel.GetInheritanceCandidates(currentLeader).Contains(candidate))
                    {
                        result.Add(BannerKingsConfig.Instance.TitleModel.GetInheritanceHeirScore(currentLeader,
                            candidate,
                            title.Contract,
                            explanations).ResultNumber, new TextObject("{=mL5FFwSG}{CLAN} inheritor")
                            .SetTextVariable("CLAN", currentLeader.Clan.Name));
                    }

                    result.Add(TaleWorlds.CampaignSystem.Campaign.Current.Models.DiplomacyModel.GetClanStrength(candidate.Clan) / 400f,
                        new TextObject("{=dnq6qC7y}Military power"));

                    result.Add(candidate.GetSkillValue(DefaultSkills.Leadership) / 2f, DefaultSkills.Leadership.Name);
                    result.Add(candidate.GetSkillValue(DefaultSkills.Tactics) / 2f, DefaultSkills.Tactics.Name);
                    result.Add(candidate.GetSkillValue(DefaultSkills.Charm) / 2f, DefaultSkills.Charm.Name);

                    result.Add(candidate.Clan.Tier * 25f, GameTexts.FindText("str_clan_tier_bonus"));
                    if (candidate.MapFaction != currentLeader.MapFaction)
                        result.AddFactor(-0.5f, new TextObject("{=!}Foreign candidate"));
                    return result;
                });
        }
    }

    [HarmonyPatch(typeof(DefaultGovernments), "Initialize")]
    internal class DefaultGovernmentsInitializePatch
    {
        public static bool Prefix(DefaultGovernments __instance)
        {
            __instance.Republic.Initialize(new TextObject("Republic"),
                new TextObject("Republics were a form of goverment popular in medieval italic trade countries and rapidly popularized over the world after the french revolution. They were traditionally quite resistant to any attempts of power concentration at the hands of one or another senator, lest they turn into a monarchical regime... Yet, at times of war, strong, unquestioned leadership was needed, wich could be granted to a temporary senator holding all the power - the Diktator. History teaches that one Diktator too influential is all it takes to topple a republic."),
                new TextObject("{=onDTTX11}- Every year, an election for ruler takes place (Republican succession){newline}- Settlement production quality +10%{newline}- Settlement loyalty +1{newline}- Settlement mercantilism +50%"),
                0.5f,
                -1f,
                0.6f,
                1f,
                new List<PolicyObject>()
                {
                    DefaultPolicies.SacredMajesty,
                    DefaultPolicies.CrownDuty,
                    DefaultPolicies.ImperialTowns,
                    DefaultPolicies.RoyalCommissions,
                    DefaultPolicies.RoyalGuard,
                    DefaultPolicies.RoyalPrivilege,
                    DefaultPolicies.WarTax,
                    DefaultPolicies.CastleCharters,
                    DefaultPolicies.StateMonopolies,
                    DefaultPolicies.DebasementOfTheCurrency,
                    DefaultPolicies.LandTax,
                    BKPolicies.Instance.LimitedArmyPrivilege
                },
                new List<Succession>()
                {
                    DefaultSuccessions.Instance.Republic,
                    DefaultSuccessions.Instance.Dictatorship,
                    DefaultSuccessions.Instance.AseraiElective
                });

            __instance.Imperial.Initialize(new TextObject("Imperial"),
                new TextObject("{=G6WHqN14}The Imperial government were popular mainly in northern african sultanates and caliphates. Unlike feudal monarchies, the empire, though often hereditary, is built on a different ethos. Though a Senate may exist, it is more often than not a formality than an effective political force. All property is considered ultimately the emperor's, and thus their vassals are mere administrators, rather than owners of their domains. In theory, ruling families only inherit their properties by the emperor's grace, who temporarily holds them in the family head's death, before granting it back to them. In truth, many emperors cannot afford to not concede to such influential families. Imperial fiefs are highly integrated, with security and assimilation as priorities."),
                new TextObject("{=nMxCoz9E}- Settlement cultural weight +40%{newline}- Settlement security +1{newline}- Settlement mercantilism +20%"),
                0.2f,
                1f,
                -0.2f,
                -0.5f,
                new List<PolicyObject>()
                {
                    DefaultPolicies.WarTax,
                    DefaultPolicies.LordsPrivyCouncil,
                    DefaultPolicies.FeudalInheritance,
                    DefaultPolicies.CastleCharters,
                    DefaultPolicies.Bailiffs,
                    DefaultPolicies.HuntingRights,
                    DefaultPolicies.GrazingRights,
                    DefaultPolicies.Marshals,
                    DefaultPolicies.Cantons,
                    DefaultPolicies.CouncilOfTheCommons,
                    DefaultPolicies.NobleRetinues,
                    BKPolicies.Instance.LimitedArmyPrivilege
                },
                new List<Succession>()
                {
                    DefaultSuccessions.Instance.Imperial,
                    DefaultSuccessions.Instance.Dictatorship,
                    DefaultSuccessions.Instance.AseraiElective,
                    DefaultSuccessions.Instance.Hereditary,
                    DefaultSuccessions.Instance.TribalElective,
                    DefaultSuccessions.Instance.TheocraticElective
                });

            __instance.Tribal.Initialize(new TextObject("{=7FEVXuj2}Tribal"),
                new TextObject("{=!}Tribal goverments were popular before times of large kindoms and empires. In XIII century it is still very popular among mongol and turkish tribes from the steppes."),
                new TextObject("{=C1WUnGZJ}- Settlement militia +1{newline}- Settlement draft efficiency +20%{newline}- Settlement mercantilism +30%"),
                0.3f,
                -0.7f,
                0.5f,
                0.4f,
                new List<PolicyObject>()
                {
                    DefaultPolicies.SacredMajesty,
                    DefaultPolicies.DebasementOfTheCurrency,
                    DefaultPolicies.CrownDuty,
                    DefaultPolicies.ImperialTowns,
                    DefaultPolicies.RoyalCommissions,
                    DefaultPolicies.RoyalGuard,
                    DefaultPolicies.RoyalPrivilege,
                    DefaultPolicies.CastleCharters,
                    DefaultPolicies.Senate,
                    DefaultPolicies.Citizenship,
                    DefaultPolicies.Magistrates,
                    DefaultPolicies.FeudalInheritance,
                    DefaultPolicies.PrecarialLandTenure,
                    BKPolicies.Instance.LimitedArmyPrivilege,
                },
                new List<Succession>()
                {
                    DefaultSuccessions.Instance.TribalElective,
                });

            __instance.Feudal.Initialize(new TextObject("{=bAzfVpGy}Feudal"),
                new TextObject("{=bAzfVpGy}Feudal governments stablish the authority of a life-serving ruler, while keeping a relatively degree of autonomy to their vassals. Unlike in empires, feudal societies have a strong sense of property, and legal claims and technicalities often take precedence over other factors. While the king or queen draw great influence, their subordinate peers are guaranteed certain securities that the ruler is bound by law to follow."),
                new TextObject("{=Xd4uto3m}- Petitioning rights yields no relation loss{newline}- Settlement stability +5%{newline}- Settlement prod. efficiency +10%{newline}- Settlement mercantilism +15%"),
                0.15f,
                -0.4f,
                0.7f,
                -0.2f,
                new List<PolicyObject>()
                {
                    DefaultPolicies.ImperialTowns,
                    DefaultPolicies.PrecarialLandTenure,
                    DefaultPolicies.WarTax,
                    DefaultPolicies.StateMonopolies,
                    DefaultPolicies.Senate,
                    DefaultPolicies.CouncilOfTheCommons,
                    DefaultPolicies.Citizenship,
                    DefaultPolicies.TribunesOfThePeople,
                    DefaultPolicies.Cantons,
                    DefaultPolicies.Magistrates
                },
                new List<Succession>()
                {
                    DefaultSuccessions.Instance.FeudalElective,
                    DefaultSuccessions.Instance.TheocraticElective,
                    DefaultSuccessions.Instance.Hereditary,
                    DefaultSuccessions.Instance.BattanianElective,
                    DefaultSuccessions.Instance.WilundingElective,
                    DefaultSuccessions.Instance.AseraiElective
                });

            return false;
        }
    }


    [HarmonyPatch(typeof(TitleManager), "CalculateHeroSuzerain")]
    internal class CalculateHeroSuzerainPatch
    {
        public static void Postfix(TitleManager __instance, ref FeudalTitle __result, Hero hero)
        {
            if (__result != null && __result.deJure == null)
            {
                __result = null;
            }
        }
    }

    //should be replaced later by real culture specific innovations. Now only a placeholder
    [HarmonyPatch(typeof(DefaultInnovations), "GetCultureDefaultInnovations")]
    internal class GetCultureDefaultInnovationsPatch
    {
        public static void Postfix(ref DefaultEras __instance, ref List<Innovation> __result, CultureObject culture)
        {
            if (true)
            {
                __result = new List<Innovation>
                {
                    DefaultTypeInitializer<DefaultInnovations, Innovation>.Instance.Burgage,
                    DefaultTypeInitializer<DefaultInnovations, Innovation>.Instance.HeavyPlough,
                    DefaultTypeInitializer<DefaultInnovations, Innovation>.Instance.HorseCollar,
                    DefaultTypeInitializer<DefaultInnovations, Innovation>.Instance.Crossbows,
                    DefaultTypeInitializer<DefaultInnovations, Innovation>.Instance.Mills
                };
            }
        }
    }


    //due to already low fps problem generating additional clans disabled for now
    [HarmonyPatch(typeof(BKGentryBehavior), "CreateGentryClan")]
    internal class CreateGentryClanPatch
    {
        public static bool Prefix()
        {
            return false;
        }
    }


    //classes made to fix the infinite loading - one of original bannerlord events is not fired on game campaign star in anno domini
    internal static class BKCampaignStartCompatState
    {
        public static readonly ConditionalWeakTable<BKCampaignStartBehavior, State> States
            = new ConditionalWeakTable<BKCampaignStartBehavior, State>();

        internal class State
        {
            public bool PendingStartUI;
            public bool Executed;
        }
    }

    [HarmonyPatch(typeof(BKCampaignStartBehavior), "RegisterEvents")]
    internal static class BKCampaignStartBehavior_RegisterEvents_Patch
    {
        public static bool Prefix(BKCampaignStartBehavior __instance)
        {
            var state = BKCampaignStartCompatState.States.GetOrCreateValue(__instance);

            CampaignEvents.OnSessionLaunchedEvent.AddNonSerializedListener(
                __instance,
                starter =>
                {
                    AccessTools.Method(__instance.GetType(), "OnSessionLaunched")
                        .Invoke(__instance, new object[] { starter });
                });

            CampaignEvents.OnCharacterCreationIsOverEvent.AddNonSerializedListener(
                __instance,
                () => state.PendingStartUI = true);

            CampaignEvents.TickEvent.AddNonSerializedListener(
                __instance,
                dt => TryRunBKStartup(__instance, state));

            return false;
        }

        private static void TryRunBKStartup(
            BKCampaignStartBehavior instance,
            BKCampaignStartCompatState.State state)
        {
            if (!state.PendingStartUI || state.Executed)
                return;

            var gsm = Game.Current?.GameStateManager;
            if (gsm?.ActiveState is MapState)
            {
                state.PendingStartUI = false;
                state.Executed = true;

                instance.OnCharacterCreationOver(); // SAFE here
            }
        }
    }


    
    //TODO: Papal election model: choose from catholic faith preachers, and make him leader of papal states
    [HarmonyPatch(typeof(FaithGroup), nameof(FaithGroup.MakeHeroLeader))]
    internal static class MakePopeLeaderOfPapalStates
    {
        public static void Postfix(
            FaithGroup __instance,
            Religion religion,
            ref Hero leader,
            Hero creator,
            bool notify)
        {
            return;
            if (__instance.StringId != "WesternCatholicism") return;

            Kingdom vlandia = Kingdom.All
                .FirstOrDefault(k => k.StringId == "vlandia");

            

            Settlement homeSettlment = leader.CurrentSettlement;

            TextObject newName = Campaign.Current.GetCampaignBehavior<PopeNameGeneratorBehavior>().GenerateRandomName();


            leader.ChangeState(Hero.CharacterStates.Active);
            leader.SetNewOccupation(Occupation.Lord);
            leader.Clan = vlandia.Leader.Clan;

            InformationManager.DisplayMessage(new InformationMessage(
                new TextObject("{=!}{HERO}, the archdeacon of {HOME_SETTLEMENT} has been chosen as new Pope under the name {NAME}.")
                .SetTextVariable("HERO", leader.Name)
                .SetTextVariable("HOME_SETTLEMENT", homeSettlment.GetName())
                .SetTextVariable("NAME", newName)
                .ToString(),
                Color.White));


            leader.SetName(newName, newName);
            
            AD1259Religions.Instance.Catholicism.GenerateClergyman(homeSettlment);

            KingdomActions.SetRulerWithTitle(leader, vlandia);

            leader.ChangeHeroGold(100000);

            MobileParty party = LordPartyComponent.CreateLordParty(
                "papal_party",
                leader,
                homeSettlment.GatePosition,
                0f,
                homeSettlment,
                leader);
        }
    }


    //Disable listing all cultures from choose religion windows - it overflows the window
    [HarmonyPatch(typeof(ReligionStartOptionVM), "GetHint")]
    public class ReligionVM_GetHint_Patch
    {
        public static bool Prefix(ref List<TooltipProperty> __result, ReligionStartOptionVM __instance)
        {
            var religion = __instance.Religion;
            var list = new List<TooltipProperty>();

            list.Add(new TooltipProperty(string.Empty,
                religion.GetName().ToString(),
                0, false,
                TooltipProperty.TooltipPropertyFlags.Title));

            list.Add(new TooltipProperty(string.Empty,
                religion.Faith.GetDescriptionHint().ToString(),
                0, false,
                TooltipProperty.TooltipPropertyFlags.MultiLine));

            UIHelper.TooltipAddEmptyLine(list);

            list.Add(new TooltipProperty("Kingdoms", " ", 0));
            UIHelper.TooltipAddSeperator(list);

            int kingdomCount = 0;

            foreach (var kingdom in Kingdom.All)
            {
                if (BannerKingsConfig.Instance.ReligionsManager
                    .GetHeroReligion(kingdom.RulingClan.Leader) == religion)
                {
                    list.Add(new TooltipProperty("", kingdom.Name.ToString(), 0));
                    kingdomCount++;
                }
            }

            if (kingdomCount == 0)
            {
                list.Add(new TooltipProperty("",
                    "Not an official religion in any kingdom", 0));
            }

            __result = list;
            return false;
        }
    }
}
