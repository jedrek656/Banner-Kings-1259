using BannerKings;
using BannerKings.Managers.Cultures;
using BannnerKings1259.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Localization;
using TaleWorlds.ObjectSystem;

namespace BannerKings1259
{
    internal class AD1259Titles : DefaultTypeInitializer<AD1259Titles, CulturalTitleName>
    {
        public CulturalTitleName aragoneseEmpire { get; private set; }
        public CulturalTitleName aragoneseKingdom { get; private set; }
        public CulturalTitleName aragoneseDuchy { get; private set; }
        public CulturalTitleName aragoneseCounty { get; private set; }
        public CulturalTitleName aragoneseBarony { get; private set; }
        public CulturalTitleName aragoneseLordship { get; private set; }
        public CulturalTitleName aragonesePrince { get; private set; }
        public CulturalTitleName aragoneseKnight { get; private set; }
        public CulturalTitleName armeniaEmpire { get; private set; }
        public CulturalTitleName armeniaKingdom { get; private set; }
        public CulturalTitleName armeniaDuchy { get; private set; }
        public CulturalTitleName armeniaCounty { get; private set; }
        public CulturalTitleName armeniaBarony { get; private set; }
        public CulturalTitleName armeniaLordship { get; private set; }
        public CulturalTitleName armeniaPrince { get; private set; }
        public CulturalTitleName armeniaKnight { get; private set; }
        public CulturalTitleName balticEmpire { get; private set; }
        public CulturalTitleName balticKingdom { get; private set; }
        public CulturalTitleName balticDuchy { get; private set; }
        public CulturalTitleName balticCounty { get; private set; }
        public CulturalTitleName balticBarony { get; private set; }
        public CulturalTitleName balticLordship { get; private set; }
        public CulturalTitleName balticPrince { get; private set; }
        public CulturalTitleName balticKnight { get; private set; }
        public CulturalTitleName berberEmpire { get; private set; }
        public CulturalTitleName berberKingdom { get; private set; }
        public CulturalTitleName berberDuchy { get; private set; }
        public CulturalTitleName berberCounty { get; private set; }
        public CulturalTitleName berberBarony { get; private set; }
        public CulturalTitleName berberLordship { get; private set; }
        public CulturalTitleName berberPrince { get; private set; }
        public CulturalTitleName berberKnight { get; private set; }
        public CulturalTitleName bohemiaEmpire { get; private set; }
        public CulturalTitleName bohemiaKingdom { get; private set; }
        public CulturalTitleName bohemiaDuchy { get; private set; }
        public CulturalTitleName bohemiaCounty { get; private set; }
        public CulturalTitleName bohemiaBarony { get; private set; }
        public CulturalTitleName bohemiaLordship { get; private set; }
        public CulturalTitleName bohemiaPrince { get; private set; }
        public CulturalTitleName bohemiaKnight { get; private set; }
        public CulturalTitleName bosniaEmpire { get; private set; }
        public CulturalTitleName bosniaKingdom { get; private set; }
        public CulturalTitleName bosniaDuchy { get; private set; }
        public CulturalTitleName bosniaCounty { get; private set; }
        public CulturalTitleName bosniaBarony { get; private set; }
        public CulturalTitleName bosniaLordship { get; private set; }
        public CulturalTitleName bosniaPrince { get; private set; }
        public CulturalTitleName bosniaKnight { get; private set; }
        public CulturalTitleName bulgariaEmpire { get; private set; }
        public CulturalTitleName bulgariaKingdom { get; private set; }
        public CulturalTitleName bulgariaDuchy { get; private set; }
        public CulturalTitleName bulgariaCounty { get; private set; }
        public CulturalTitleName bulgariaBarony { get; private set; }
        public CulturalTitleName bulgariaLordship { get; private set; }
        public CulturalTitleName bulgariaPrince { get; private set; }
        public CulturalTitleName bulgariaKnight { get; private set; }
        public CulturalTitleName castileEmpire { get; private set; }
        public CulturalTitleName castileKingdom { get; private set; }
        public CulturalTitleName castileDuchy { get; private set; }
        public CulturalTitleName castileCounty { get; private set; }
        public CulturalTitleName castileBarony { get; private set; }
        public CulturalTitleName castileLordship { get; private set; }
        public CulturalTitleName castilePrince { get; private set; }
        public CulturalTitleName castileKnight { get; private set; }
        public CulturalTitleName crusaderEmpire { get; private set; }
        public CulturalTitleName crusaderKingdom { get; private set; }
        public CulturalTitleName crusaderDuchy { get; private set; }
        public CulturalTitleName crusaderCounty { get; private set; }
        public CulturalTitleName crusaderBarony { get; private set; }
        public CulturalTitleName crusaderLordship { get; private set; }
        public CulturalTitleName crusaderPrince { get; private set; }
        public CulturalTitleName crusaderKnight { get; private set; }
        public CulturalTitleName danishEmpire { get; private set; }
        public CulturalTitleName danishKingdom { get; private set; }
        public CulturalTitleName danishDuchy { get; private set; }
        public CulturalTitleName danishCounty { get; private set; }
        public CulturalTitleName danishBarony { get; private set; }
        public CulturalTitleName danishLordship { get; private set; }
        public CulturalTitleName danishPrince { get; private set; }
        public CulturalTitleName danishKnight { get; private set; }
        public CulturalTitleName englandEmpire { get; private set; }
        public CulturalTitleName englandKingdom { get; private set; }
        public CulturalTitleName englandDuchy { get; private set; }
        public CulturalTitleName englandCounty { get; private set; }
        public CulturalTitleName englandBarony { get; private set; }
        public CulturalTitleName englandLordship { get; private set; }
        public CulturalTitleName englandPrince { get; private set; }
        public CulturalTitleName englandKnight { get; private set; }
        public CulturalTitleName franceEmpire { get; private set; }
        public CulturalTitleName franceKingdom { get; private set; }
        public CulturalTitleName franceDuchy { get; private set; }
        public CulturalTitleName franceCounty { get; private set; }
        public CulturalTitleName franceBarony { get; private set; }
        public CulturalTitleName franceLordship { get; private set; }
        public CulturalTitleName francePrince { get; private set; }
        public CulturalTitleName franceKnight { get; private set; }
        public CulturalTitleName gealicEmpire { get; private set; }
        public CulturalTitleName gealicKingdom { get; private set; }
        public CulturalTitleName gealicDuchy { get; private set; }
        public CulturalTitleName gealicCounty { get; private set; }
        public CulturalTitleName gealicBarony { get; private set; }
        public CulturalTitleName gealicLordship { get; private set; }
        public CulturalTitleName gealicPrince { get; private set; }
        public CulturalTitleName gealicKnight { get; private set; }
        public CulturalTitleName georgiaEmpire { get; private set; }
        public CulturalTitleName georgiaKingdom { get; private set; }
        public CulturalTitleName georgiaDuchy { get; private set; }
        public CulturalTitleName georgiaCounty { get; private set; }
        public CulturalTitleName georgiaBarony { get; private set; }
        public CulturalTitleName georgiaLordship { get; private set; }
        public CulturalTitleName georgiaPrince { get; private set; }
        public CulturalTitleName georgiaKnight { get; private set; }
        public CulturalTitleName germanicEmpire { get; private set; }
        public CulturalTitleName germanicKingdom { get; private set; }
        public CulturalTitleName germanicDuchy { get; private set; }
        public CulturalTitleName germanicCounty { get; private set; }
        public CulturalTitleName germanicBarony { get; private set; }
        public CulturalTitleName germanicLordship { get; private set; }
        public CulturalTitleName germanicPrince { get; private set; }
        public CulturalTitleName germanicKnight { get; private set; }
        public CulturalTitleName andalusEmpire { get; private set; }
        public CulturalTitleName andalusKingdom { get; private set; }
        public CulturalTitleName andalusDuchy { get; private set; }
        public CulturalTitleName andalusCounty { get; private set; }
        public CulturalTitleName andalusBarony { get; private set; }
        public CulturalTitleName andalusLordship { get; private set; }
        public CulturalTitleName andalusPrince { get; private set; }
        public CulturalTitleName andalusKnight { get; private set; }
        public CulturalTitleName greekEmpire { get; private set; }
        public CulturalTitleName greekKingdom { get; private set; }
        public CulturalTitleName greekDuchy { get; private set; }
        public CulturalTitleName greekCounty { get; private set; }
        public CulturalTitleName greekBarony { get; private set; }
        public CulturalTitleName greekLordship { get; private set; }
        public CulturalTitleName greekPrince { get; private set; }
        public CulturalTitleName greekKnight { get; private set; }
        public CulturalTitleName halychEmpire { get; private set; }
        public CulturalTitleName halychKingdom { get; private set; }
        public CulturalTitleName halychDuchy { get; private set; }
        public CulturalTitleName halychCounty { get; private set; }
        public CulturalTitleName halychBarony { get; private set; }
        public CulturalTitleName halychLordship { get; private set; }
        public CulturalTitleName halychPrince { get; private set; }
        public CulturalTitleName halychKnight { get; private set; }
        public CulturalTitleName hungarianEmpire { get; private set; }
        public CulturalTitleName hungarianKingdom { get; private set; }
        public CulturalTitleName hungarianDuchy { get; private set; }
        public CulturalTitleName hungarianCounty { get; private set; }
        public CulturalTitleName hungarianBarony { get; private set; }
        public CulturalTitleName hungarianLordship { get; private set; }
        public CulturalTitleName hungarianPrince { get; private set; }
        public CulturalTitleName hungarianKnight { get; private set; }
        public CulturalTitleName ilkhanidEmpire { get; private set; }
        public CulturalTitleName ilkhanidKingdom { get; private set; }
        public CulturalTitleName ilkhanidDuchy { get; private set; }
        public CulturalTitleName ilkhanidCounty { get; private set; }
        public CulturalTitleName ilkhanidBarony { get; private set; }
        public CulturalTitleName ilkhanidLordship { get; private set; }
        public CulturalTitleName ilkhanidPrince { get; private set; }
        public CulturalTitleName ilkhanidKnight { get; private set; }
        public CulturalTitleName italianEmpire { get; private set; }
        public CulturalTitleName italianKingdom { get; private set; }
        public CulturalTitleName italianDuchy { get; private set; }
        public CulturalTitleName italianCounty { get; private set; }
        public CulturalTitleName italianBarony { get; private set; }
        public CulturalTitleName italianLordship { get; private set; }
        public CulturalTitleName italianPrince { get; private set; }
        public CulturalTitleName italianKnight { get; private set; }
        public CulturalTitleName latinEmpire { get; private set; }
        public CulturalTitleName latinKingdom { get; private set; }
        public CulturalTitleName latinDuchy { get; private set; }
        public CulturalTitleName latinCounty { get; private set; }
        public CulturalTitleName latinBarony { get; private set; }
        public CulturalTitleName latinLordship { get; private set; }
        public CulturalTitleName latinPrince { get; private set; }
        public CulturalTitleName latinKnight { get; private set; }
        public CulturalTitleName darshiEmpire { get; private set; }
        public CulturalTitleName darshiKingdom { get; private set; }
        public CulturalTitleName darshiDuchy { get; private set; }
        public CulturalTitleName darshiCounty { get; private set; }
        public CulturalTitleName darshiBarony { get; private set; }
        public CulturalTitleName darshiLordship { get; private set; }
        public CulturalTitleName darshiPrince { get; private set; }
        public CulturalTitleName darshiKnight { get; private set; }
        public CulturalTitleName cumanEmpire { get; private set; }
        public CulturalTitleName cumanKingdom { get; private set; }
        public CulturalTitleName cumanDuchy { get; private set; }
        public CulturalTitleName cumanCounty { get; private set; }
        public CulturalTitleName cumanBarony { get; private set; }
        public CulturalTitleName cumanLordship { get; private set; }
        public CulturalTitleName cumanPrince { get; private set; }
        public CulturalTitleName cumanKnight { get; private set; }
        public CulturalTitleName genoaEmpire { get; private set; }
        public CulturalTitleName genoaKingdom { get; private set; }
        public CulturalTitleName genoaDuchy { get; private set; }
        public CulturalTitleName genoaCounty { get; private set; }
        public CulturalTitleName genoaBarony { get; private set; }
        public CulturalTitleName genoaLordship { get; private set; }
        public CulturalTitleName genoaPrince { get; private set; }
        public CulturalTitleName genoaKnight { get; private set; }
        public CulturalTitleName santiagoEmpire { get; private set; }
        public CulturalTitleName santiagoKingdom { get; private set; }
        public CulturalTitleName santiagoDuchy { get; private set; }
        public CulturalTitleName santiagoCounty { get; private set; }
        public CulturalTitleName santiagoBarony { get; private set; }
        public CulturalTitleName santiagoLordship { get; private set; }
        public CulturalTitleName santiagoPrince { get; private set; }
        public CulturalTitleName santiagoKnight { get; private set; }
        public CulturalTitleName templarEmpire { get; private set; }
        public CulturalTitleName templarKingdom { get; private set; }
        public CulturalTitleName templarDuchy { get; private set; }
        public CulturalTitleName templarCounty { get; private set; }
        public CulturalTitleName templarBarony { get; private set; }
        public CulturalTitleName templarLordship { get; private set; }
        public CulturalTitleName templarPrince { get; private set; }
        public CulturalTitleName templarKnight { get; private set; }
        public CulturalTitleName samiEmpire { get; private set; }
        public CulturalTitleName samiKingdom { get; private set; }
        public CulturalTitleName samiDuchy { get; private set; }
        public CulturalTitleName samiCounty { get; private set; }
        public CulturalTitleName samiBarony { get; private set; }
        public CulturalTitleName samiLordship { get; private set; }
        public CulturalTitleName samiPrince { get; private set; }
        public CulturalTitleName samiKnight { get; private set; }
        public CulturalTitleName nizariEmpire { get; private set; }
        public CulturalTitleName nizariKingdom { get; private set; }
        public CulturalTitleName nizariDuchy { get; private set; }
        public CulturalTitleName nizariCounty { get; private set; }
        public CulturalTitleName nizariBarony { get; private set; }
        public CulturalTitleName nizariLordship { get; private set; }
        public CulturalTitleName nizariPrince { get; private set; }
        public CulturalTitleName nizariKnight { get; private set; }
        public CulturalTitleName lazarusEmpire { get; private set; }
        public CulturalTitleName lazarusKingdom { get; private set; }
        public CulturalTitleName lazarusDuchy { get; private set; }
        public CulturalTitleName lazarusCounty { get; private set; }
        public CulturalTitleName lazarusBarony { get; private set; }
        public CulturalTitleName lazarusLordship { get; private set; }
        public CulturalTitleName lazarusPrince { get; private set; }
        public CulturalTitleName lazarusKnight { get; private set; }
        public CulturalTitleName catharsEmpire { get; private set; }
        public CulturalTitleName catharsKingdom { get; private set; }
        public CulturalTitleName catharsDuchy { get; private set; }
        public CulturalTitleName catharsCounty { get; private set; }
        public CulturalTitleName catharsBarony { get; private set; }
        public CulturalTitleName catharsLordship { get; private set; }
        public CulturalTitleName catharsPrince { get; private set; }
        public CulturalTitleName catharsKnight { get; private set; }
        public CulturalTitleName hospitallerEmpire { get; private set; }
        public CulturalTitleName hospitallerKingdom { get; private set; }
        public CulturalTitleName hospitallerDuchy { get; private set; }
        public CulturalTitleName hospitallerCounty { get; private set; }
        public CulturalTitleName hospitallerBarony { get; private set; }
        public CulturalTitleName hospitallerLordship { get; private set; }
        public CulturalTitleName hospitallerPrince { get; private set; }
        public CulturalTitleName hospitallerKnight { get; private set; }
        public CulturalTitleName mongolianEmpire { get; private set; }
        public CulturalTitleName mongolianKingdom { get; private set; }
        public CulturalTitleName mongolianDuchy { get; private set; }
        public CulturalTitleName mongolianCounty { get; private set; }
        public CulturalTitleName mongolianBarony { get; private set; }
        public CulturalTitleName mongolianLordship { get; private set; }
        public CulturalTitleName mongolianPrince { get; private set; }
        public CulturalTitleName mongolianKnight { get; private set; }
        public CulturalTitleName norwegianEmpire { get; private set; }
        public CulturalTitleName norwegianKingdom { get; private set; }
        public CulturalTitleName norwegianDuchy { get; private set; }
        public CulturalTitleName norwegianCounty { get; private set; }
        public CulturalTitleName norwegianBarony { get; private set; }
        public CulturalTitleName norwegianLordship { get; private set; }
        public CulturalTitleName norwegianPrince { get; private set; }
        public CulturalTitleName norwegianKnight { get; private set; }
        public CulturalTitleName polandEmpire { get; private set; }
        public CulturalTitleName polandKingdom { get; private set; }
        public CulturalTitleName polandDuchy { get; private set; }
        public CulturalTitleName polandCounty { get; private set; }
        public CulturalTitleName polandBarony { get; private set; }
        public CulturalTitleName polandLordship { get; private set; }
        public CulturalTitleName polandPrince { get; private set; }
        public CulturalTitleName polandKnight { get; private set; }
        public CulturalTitleName portugueseEmpire { get; private set; }
        public CulturalTitleName portugueseKingdom { get; private set; }
        public CulturalTitleName portugueseDuchy { get; private set; }
        public CulturalTitleName portugueseCounty { get; private set; }
        public CulturalTitleName portugueseBarony { get; private set; }
        public CulturalTitleName portugueseLordship { get; private set; }
        public CulturalTitleName portuguesePrince { get; private set; }
        public CulturalTitleName portugueseKnight { get; private set; }
        public CulturalTitleName rusEmpire { get; private set; }
        public CulturalTitleName rusKingdom { get; private set; }
        public CulturalTitleName rusDuchy { get; private set; }
        public CulturalTitleName rusCounty { get; private set; }
        public CulturalTitleName rusBarony { get; private set; }
        public CulturalTitleName rusLordship { get; private set; }
        public CulturalTitleName rusPrince { get; private set; }
        public CulturalTitleName rusKnight { get; private set; }
        public CulturalTitleName scottishEmpire { get; private set; }
        public CulturalTitleName scottishKingdom { get; private set; }
        public CulturalTitleName scottishDuchy { get; private set; }
        public CulturalTitleName scottishCounty { get; private set; }
        public CulturalTitleName scottishBarony { get; private set; }
        public CulturalTitleName scottishLordship { get; private set; }
        public CulturalTitleName scottishPrince { get; private set; }
        public CulturalTitleName scottishKnight { get; private set; }
        public CulturalTitleName serbiaEmpire { get; private set; }
        public CulturalTitleName serbiaKingdom { get; private set; }
        public CulturalTitleName serbiaDuchy { get; private set; }
        public CulturalTitleName serbiaCounty { get; private set; }
        public CulturalTitleName serbiaBarony { get; private set; }
        public CulturalTitleName serbiaLordship { get; private set; }
        public CulturalTitleName serbiaPrince { get; private set; }
        public CulturalTitleName serbiaKnight { get; private set; }
        public CulturalTitleName swedenEmpire { get; private set; }
        public CulturalTitleName swedenKingdom { get; private set; }
        public CulturalTitleName swedenDuchy { get; private set; }
        public CulturalTitleName swedenCounty { get; private set; }
        public CulturalTitleName swedenBarony { get; private set; }
        public CulturalTitleName swedenLordship { get; private set; }
        public CulturalTitleName swedenPrince { get; private set; }
        public CulturalTitleName swedenKnight { get; private set; }
        public CulturalTitleName teutonicEmpire { get; private set; }
        public CulturalTitleName teutonicKingdom { get; private set; }
        public CulturalTitleName teutonicDuchy { get; private set; }
        public CulturalTitleName teutonicCounty { get; private set; }
        public CulturalTitleName teutonicBarony { get; private set; }
        public CulturalTitleName teutonicLordship { get; private set; }
        public CulturalTitleName teutonicPrince { get; private set; }
        public CulturalTitleName teutonicKnight { get; private set; }
        public CulturalTitleName turkishEmpire { get; private set; }
        public CulturalTitleName turkishKingdom { get; private set; }
        public CulturalTitleName turkishDuchy { get; private set; }
        public CulturalTitleName turkishCounty { get; private set; }
        public CulturalTitleName turkishBarony { get; private set; }
        public CulturalTitleName turkishLordship { get; private set; }
        public CulturalTitleName turkishPrince { get; private set; }
        public CulturalTitleName turkishKnight { get; private set; }
        public CulturalTitleName walesEmpire { get; private set; }
        public CulturalTitleName walesKingdom { get; private set; }
        public CulturalTitleName walesDuchy { get; private set; }
        public CulturalTitleName walesCounty { get; private set; }
        public CulturalTitleName walesBarony { get; private set; }
        public CulturalTitleName walesLordship { get; private set; }
        public CulturalTitleName walesPrince { get; private set; }
        public CulturalTitleName walesKnight { get; private set; }

        public override IEnumerable<CulturalTitleName> All
        {
            get
            {
                yield return aragoneseEmpire;
                yield return aragoneseKingdom;
                yield return aragoneseDuchy;
                yield return aragoneseCounty;
                yield return aragoneseBarony;
                yield return aragoneseLordship;
                yield return aragonesePrince;
                yield return aragoneseKnight;
                yield return armeniaEmpire;
                yield return armeniaKingdom;
                yield return armeniaDuchy;
                yield return armeniaCounty;
                yield return armeniaBarony;
                yield return armeniaLordship;
                yield return armeniaPrince;
                yield return armeniaKnight;
                yield return balticEmpire;
                yield return balticKingdom;
                yield return balticDuchy;
                yield return balticCounty;
                yield return balticBarony;
                yield return balticLordship;
                yield return balticPrince;
                yield return balticKnight;
                yield return berberEmpire;
                yield return berberKingdom;
                yield return berberDuchy;
                yield return berberCounty;
                yield return berberBarony;
                yield return berberLordship;
                yield return berberPrince;
                yield return berberKnight;
                yield return bohemiaEmpire;
                yield return bohemiaKingdom;
                yield return bohemiaDuchy;
                yield return bohemiaCounty;
                yield return bohemiaBarony;
                yield return bohemiaLordship;
                yield return bohemiaPrince;
                yield return bohemiaKnight;
                yield return bosniaEmpire;
                yield return bosniaKingdom;
                yield return bosniaDuchy;
                yield return bosniaCounty;
                yield return bosniaBarony;
                yield return bosniaLordship;
                yield return bosniaPrince;
                yield return bosniaKnight;
                yield return bulgariaEmpire;
                yield return bulgariaKingdom;
                yield return bulgariaDuchy;
                yield return bulgariaCounty;
                yield return bulgariaBarony;
                yield return bulgariaLordship;
                yield return bulgariaPrince;
                yield return bulgariaKnight;
                yield return castileEmpire;
                yield return castileKingdom;
                yield return castileDuchy;
                yield return castileCounty;
                yield return castileBarony;
                yield return castileLordship;
                yield return castilePrince;
                yield return castileKnight;
                yield return crusaderEmpire;
                yield return crusaderKingdom;
                yield return crusaderDuchy;
                yield return crusaderCounty;
                yield return crusaderBarony;
                yield return crusaderLordship;
                yield return crusaderPrince;
                yield return crusaderKnight;
                yield return danishEmpire;
                yield return danishKingdom;
                yield return danishDuchy;
                yield return danishCounty;
                yield return danishBarony;
                yield return danishLordship;
                yield return danishPrince;
                yield return danishKnight;
                yield return englandEmpire;
                yield return englandKingdom;
                yield return englandDuchy;
                yield return englandCounty;
                yield return englandBarony;
                yield return englandLordship;
                yield return englandPrince;
                yield return englandKnight;
                yield return franceEmpire;
                yield return franceKingdom;
                yield return franceDuchy;
                yield return franceCounty;
                yield return franceBarony;
                yield return franceLordship;
                yield return francePrince;
                yield return franceKnight;
                yield return gealicEmpire;
                yield return gealicKingdom;
                yield return gealicDuchy;
                yield return gealicCounty;
                yield return gealicBarony;
                yield return gealicLordship;
                yield return gealicPrince;
                yield return gealicKnight;
                yield return georgiaEmpire;
                yield return georgiaKingdom;
                yield return georgiaDuchy;
                yield return georgiaCounty;
                yield return georgiaBarony;
                yield return georgiaLordship;
                yield return georgiaPrince;
                yield return georgiaKnight;
                yield return germanicEmpire;
                yield return germanicKingdom;
                yield return germanicDuchy;
                yield return germanicCounty;
                yield return germanicBarony;
                yield return germanicLordship;
                yield return germanicPrince;
                yield return germanicKnight;
                yield return andalusEmpire;
                yield return andalusKingdom;
                yield return andalusDuchy;
                yield return andalusCounty;
                yield return andalusBarony;
                yield return andalusLordship;
                yield return andalusPrince;
                yield return andalusKnight;
                yield return greekEmpire;
                yield return greekKingdom;
                yield return greekDuchy;
                yield return greekCounty;
                yield return greekBarony;
                yield return greekLordship;
                yield return greekPrince;
                yield return greekKnight;
                yield return halychEmpire;
                yield return halychKingdom;
                yield return halychDuchy;
                yield return halychCounty;
                yield return halychBarony;
                yield return halychLordship;
                yield return halychPrince;
                yield return halychKnight;
                yield return hungarianEmpire;
                yield return hungarianKingdom;
                yield return hungarianDuchy;
                yield return hungarianCounty;
                yield return hungarianBarony;
                yield return hungarianLordship;
                yield return hungarianPrince;
                yield return hungarianKnight;
                yield return ilkhanidEmpire;
                yield return ilkhanidKingdom;
                yield return ilkhanidDuchy;
                yield return ilkhanidCounty;
                yield return ilkhanidBarony;
                yield return ilkhanidLordship;
                yield return ilkhanidPrince;
                yield return ilkhanidKnight;
                yield return italianEmpire;
                yield return italianKingdom;
                yield return italianDuchy;
                yield return italianCounty;
                yield return italianBarony;
                yield return italianLordship;
                yield return italianPrince;
                yield return italianKnight;
                yield return latinEmpire;
                yield return latinKingdom;
                yield return latinDuchy;
                yield return latinCounty;
                yield return latinBarony;
                yield return latinLordship;
                yield return latinPrince;
                yield return latinKnight;
                yield return darshiEmpire;
                yield return darshiKingdom;
                yield return darshiDuchy;
                yield return darshiCounty;
                yield return darshiBarony;
                yield return darshiLordship;
                yield return darshiPrince;
                yield return darshiKnight;
                yield return cumanEmpire;
                yield return cumanKingdom;
                yield return cumanDuchy;
                yield return cumanCounty;
                yield return cumanBarony;
                yield return cumanLordship;
                yield return cumanPrince;
                yield return cumanKnight;
                yield return genoaEmpire;
                yield return genoaKingdom;
                yield return genoaDuchy;
                yield return genoaCounty;
                yield return genoaBarony;
                yield return genoaLordship;
                yield return genoaPrince;
                yield return genoaKnight;
                yield return santiagoEmpire;
                yield return santiagoKingdom;
                yield return santiagoDuchy;
                yield return santiagoCounty;
                yield return santiagoBarony;
                yield return santiagoLordship;
                yield return santiagoPrince;
                yield return santiagoKnight;
                yield return templarEmpire;
                yield return templarKingdom;
                yield return templarDuchy;
                yield return templarCounty;
                yield return templarBarony;
                yield return templarLordship;
                yield return templarPrince;
                yield return templarKnight;
                yield return samiEmpire;
                yield return samiKingdom;
                yield return samiDuchy;
                yield return samiCounty;
                yield return samiBarony;
                yield return samiLordship;
                yield return samiPrince;
                yield return samiKnight;
                yield return nizariEmpire;
                yield return nizariKingdom;
                yield return nizariDuchy;
                yield return nizariCounty;
                yield return nizariBarony;
                yield return nizariLordship;
                yield return nizariPrince;
                yield return nizariKnight;
                yield return lazarusEmpire;
                yield return lazarusKingdom;
                yield return lazarusDuchy;
                yield return lazarusCounty;
                yield return lazarusBarony;
                yield return lazarusLordship;
                yield return lazarusPrince;
                yield return lazarusKnight;
                yield return catharsEmpire;
                yield return catharsKingdom;
                yield return catharsDuchy;
                yield return catharsCounty;
                yield return catharsBarony;
                yield return catharsLordship;
                yield return catharsPrince;
                yield return catharsKnight;
                yield return hospitallerEmpire;
                yield return hospitallerKingdom;
                yield return hospitallerDuchy;
                yield return hospitallerCounty;
                yield return hospitallerBarony;
                yield return hospitallerLordship;
                yield return hospitallerPrince;
                yield return hospitallerKnight;
                yield return mongolianEmpire;
                yield return mongolianKingdom;
                yield return mongolianDuchy;
                yield return mongolianCounty;
                yield return mongolianBarony;
                yield return mongolianLordship;
                yield return mongolianPrince;
                yield return mongolianKnight;
                yield return norwegianEmpire;
                yield return norwegianKingdom;
                yield return norwegianDuchy;
                yield return norwegianCounty;
                yield return norwegianBarony;
                yield return norwegianLordship;
                yield return norwegianPrince;
                yield return norwegianKnight;
                yield return polandEmpire;
                yield return polandKingdom;
                yield return polandDuchy;
                yield return polandCounty;
                yield return polandBarony;
                yield return polandLordship;
                yield return polandPrince;
                yield return polandKnight;
                yield return portugueseEmpire;
                yield return portugueseKingdom;
                yield return portugueseDuchy;
                yield return portugueseCounty;
                yield return portugueseBarony;
                yield return portugueseLordship;
                yield return portuguesePrince;
                yield return portugueseKnight;
                yield return rusEmpire;
                yield return rusKingdom;
                yield return rusDuchy;
                yield return rusCounty;
                yield return rusBarony;
                yield return rusLordship;
                yield return rusPrince;
                yield return rusKnight;
                yield return scottishEmpire;
                yield return scottishKingdom;
                yield return scottishDuchy;
                yield return scottishCounty;
                yield return scottishBarony;
                yield return scottishLordship;
                yield return scottishPrince;
                yield return scottishKnight;
                yield return serbiaEmpire;
                yield return serbiaKingdom;
                yield return serbiaDuchy;
                yield return serbiaCounty;
                yield return serbiaBarony;
                yield return serbiaLordship;
                yield return serbiaPrince;
                yield return serbiaKnight;
                yield return swedenEmpire;
                yield return swedenKingdom;
                yield return swedenDuchy;
                yield return swedenCounty;
                yield return swedenBarony;
                yield return swedenLordship;
                yield return swedenPrince;
                yield return swedenKnight;
                yield return teutonicEmpire;
                yield return teutonicKingdom;
                yield return teutonicDuchy;
                yield return teutonicCounty;
                yield return teutonicBarony;
                yield return teutonicLordship;
                yield return teutonicPrince;
                yield return teutonicKnight;
                yield return turkishEmpire;
                yield return turkishKingdom;
                yield return turkishDuchy;
                yield return turkishCounty;
                yield return turkishBarony;
                yield return turkishLordship;
                yield return turkishPrince;
                yield return turkishKnight;
                yield return walesEmpire;
                yield return walesKingdom;
                yield return walesDuchy;
                yield return walesCounty;
                yield return walesBarony;
                yield return walesLordship;
                yield return walesPrince;
                yield return walesKnight;
            }
        }

        public override void Initialize()
        {

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

            bool english = BannerKings1259Settings.Instance.UseEnglishTitles;

            this.aragoneseEmpire = CulturalTitleName.CreateEmpire(
            "aragoneseEmpire",
            aragonese,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.aragoneseKingdom = CulturalTitleName.CreateKingdom(
            "aragoneseKingdom",
            aragonese,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.aragoneseDuchy = CulturalTitleName.CreateDuchy(
            "aragoneseDuchy",
            aragonese,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.aragoneseCounty = CulturalTitleName.CreateCounty(
            "aragoneseCounty",
            aragonese,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.aragoneseBarony = CulturalTitleName.CreateBarony(
            "aragoneseBarony",
            aragonese,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.aragoneseLordship = CulturalTitleName.CreateLordship(
            "aragoneseLordship",
            aragonese,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.aragonesePrince = CulturalTitleName.CreatePrince(
            "aragonesePrince",
            aragonese,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.aragoneseKnight = CulturalTitleName.CreateKnight(
            "aragoneseKnight",
            aragonese,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.armeniaEmpire = CulturalTitleName.CreateEmpire(
            "armeniaEmpire",
            armenia,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.armeniaKingdom = CulturalTitleName.CreateKingdom(
            "armeniaKingdom",
            armenia,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.armeniaDuchy = CulturalTitleName.CreateDuchy(
            "armeniaDuchy",
            armenia,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.armeniaCounty = CulturalTitleName.CreateCounty(
            "armeniaCounty",
            armenia,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.armeniaBarony = CulturalTitleName.CreateBarony(
            "armeniaBarony",
            armenia,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.armeniaLordship = CulturalTitleName.CreateLordship(
            "armeniaLordship",
            armenia,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.armeniaPrince = CulturalTitleName.CreatePrince(
            "armeniaPrince",
            armenia,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.armeniaKnight = CulturalTitleName.CreateKnight(
            "armeniaKnight",
            armenia,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.balticEmpire = CulturalTitleName.CreateEmpire(
            "balticEmpire",
            baltic,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.balticKingdom = CulturalTitleName.CreateKingdom(
            "balticKingdom",
            baltic,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.balticDuchy = CulturalTitleName.CreateDuchy(
            "balticDuchy",
            baltic,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.balticCounty = CulturalTitleName.CreateCounty(
            "balticCounty",
            baltic,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.balticBarony = CulturalTitleName.CreateBarony(
            "balticBarony",
            baltic,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.balticLordship = CulturalTitleName.CreateLordship(
            "balticLordship",
            baltic,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.balticPrince = CulturalTitleName.CreatePrince(
            "balticPrince",
            baltic,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.balticKnight = CulturalTitleName.CreateKnight(
            "balticKnight",
            baltic,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.berberEmpire = CulturalTitleName.CreateEmpire(
            "berberEmpire",
            berber,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.berberKingdom = CulturalTitleName.CreateKingdom(
            "berberKingdom",
            berber,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.berberDuchy = CulturalTitleName.CreateDuchy(
            "berberDuchy",
            berber,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.berberCounty = CulturalTitleName.CreateCounty(
            "berberCounty",
            berber,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.berberBarony = CulturalTitleName.CreateBarony(
            "berberBarony",
            berber,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.berberLordship = CulturalTitleName.CreateLordship(
            "berberLordship",
            berber,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.berberPrince = CulturalTitleName.CreatePrince(
            "berberPrince",
            berber,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.berberKnight = CulturalTitleName.CreateKnight(
            "berberKnight",
            berber,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.bohemiaEmpire = CulturalTitleName.CreateEmpire(
            "bohemiaEmpire",
            bohemia,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.bohemiaKingdom = CulturalTitleName.CreateKingdom(
            "bohemiaKingdom",
            bohemia,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.bohemiaDuchy = CulturalTitleName.CreateDuchy(
            "bohemiaDuchy",
            bohemia,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.bohemiaCounty = CulturalTitleName.CreateCounty(
            "bohemiaCounty",
            bohemia,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.bohemiaBarony = CulturalTitleName.CreateBarony(
            "bohemiaBarony",
            bohemia,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.bohemiaLordship = CulturalTitleName.CreateLordship(
            "bohemiaLordship",
            bohemia,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.bohemiaPrince = CulturalTitleName.CreatePrince(
            "bohemiaPrince",
            bohemia,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.bohemiaKnight = CulturalTitleName.CreateKnight(
            "bohemiaKnight",
            bohemia,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.bosniaEmpire = CulturalTitleName.CreateEmpire(
            "bosniaEmpire",
            bosnia,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.bosniaKingdom = CulturalTitleName.CreateKingdom(
            "bosniaKingdom",
            bosnia,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.bosniaDuchy = CulturalTitleName.CreateDuchy(
            "bosniaDuchy",
            bosnia,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.bosniaCounty = CulturalTitleName.CreateCounty(
            "bosniaCounty",
            bosnia,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.bosniaBarony = CulturalTitleName.CreateBarony(
            "bosniaBarony",
            bosnia,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.bosniaLordship = CulturalTitleName.CreateLordship(
            "bosniaLordship",
            bosnia,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.bosniaPrince = CulturalTitleName.CreatePrince(
            "bosniaPrince",
            bosnia,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.bosniaKnight = CulturalTitleName.CreateKnight(
            "bosniaKnight",
            bosnia,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.bulgariaEmpire = CulturalTitleName.CreateEmpire(
            "bulgariaEmpire",
            bulgaria,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.bulgariaKingdom = CulturalTitleName.CreateKingdom(
            "bulgariaKingdom",
            bulgaria,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.bulgariaDuchy = CulturalTitleName.CreateDuchy(
            "bulgariaDuchy",
            bulgaria,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.bulgariaCounty = CulturalTitleName.CreateCounty(
            "bulgariaCounty",
            bulgaria,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.bulgariaBarony = CulturalTitleName.CreateBarony(
            "bulgariaBarony",
            bulgaria,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.bulgariaLordship = CulturalTitleName.CreateLordship(
            "bulgariaLordship",
            bulgaria,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.bulgariaPrince = CulturalTitleName.CreatePrince(
            "bulgariaPrince",
            bulgaria,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.bulgariaKnight = CulturalTitleName.CreateKnight(
            "bulgariaKnight",
            bulgaria,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.castileEmpire = CulturalTitleName.CreateEmpire(
            "castileEmpire",
            castile,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.castileKingdom = CulturalTitleName.CreateKingdom(
            "castileKingdom",
            castile,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.castileDuchy = CulturalTitleName.CreateDuchy(
            "castileDuchy",
            castile,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.castileCounty = CulturalTitleName.CreateCounty(
            "castileCounty",
            castile,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.castileBarony = CulturalTitleName.CreateBarony(
            "castileBarony",
            castile,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.castileLordship = CulturalTitleName.CreateLordship(
            "castileLordship",
            castile,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.castilePrince = CulturalTitleName.CreatePrince(
            "castilePrince",
            castile,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.castileKnight = CulturalTitleName.CreateKnight(
            "castileKnight",
            castile,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.crusaderEmpire = CulturalTitleName.CreateEmpire(
            "crusaderEmpire",
            crusader,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.crusaderKingdom = CulturalTitleName.CreateKingdom(
            "crusaderKingdom",
            crusader,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.crusaderDuchy = CulturalTitleName.CreateDuchy(
            "crusaderDuchy",
            crusader,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.crusaderCounty = CulturalTitleName.CreateCounty(
            "crusaderCounty",
            crusader,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.crusaderBarony = CulturalTitleName.CreateBarony(
            "crusaderBarony",
            crusader,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.crusaderLordship = CulturalTitleName.CreateLordship(
            "crusaderLordship",
            crusader,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.crusaderPrince = CulturalTitleName.CreatePrince(
            "crusaderPrince",
            crusader,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.crusaderKnight = CulturalTitleName.CreateKnight(
            "crusaderKnight",
            crusader,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.danishEmpire = CulturalTitleName.CreateEmpire(
            "danishEmpire",
            danish,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.danishKingdom = CulturalTitleName.CreateKingdom(
            "danishKingdom",
            danish,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.danishDuchy = CulturalTitleName.CreateDuchy(
            "danishDuchy",
            danish,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.danishCounty = CulturalTitleName.CreateCounty(
            "danishCounty",
            danish,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.danishBarony = CulturalTitleName.CreateBarony(
            "danishBarony",
            danish,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.danishLordship = CulturalTitleName.CreateLordship(
            "danishLordship",
            danish,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.danishPrince = CulturalTitleName.CreatePrince(
            "danishPrince",
            danish,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.danishKnight = CulturalTitleName.CreateKnight(
            "danishKnight",
            danish,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.englandEmpire = CulturalTitleName.CreateEmpire(
            "englandEmpire",
            england,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.englandKingdom = CulturalTitleName.CreateKingdom(
            "englandKingdom",
            england,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.englandDuchy = CulturalTitleName.CreateDuchy(
            "englandDuchy",
            england,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.englandCounty = CulturalTitleName.CreateCounty(
            "englandCounty",
            england,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.englandBarony = CulturalTitleName.CreateBarony(
            "englandBarony",
            england,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.englandLordship = CulturalTitleName.CreateLordship(
            "englandLordship",
            england,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.englandPrince = CulturalTitleName.CreatePrince(
            "englandPrince",
            england,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.englandKnight = CulturalTitleName.CreateKnight(
            "englandKnight",
            england,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.franceEmpire = CulturalTitleName.CreateEmpire(
            "franceEmpire",
            france,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.franceKingdom = CulturalTitleName.CreateKingdom(
            "franceKingdom",
            france,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.franceDuchy = CulturalTitleName.CreateDuchy(
            "franceDuchy",
            france,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.franceCounty = CulturalTitleName.CreateCounty(
            "franceCounty",
            france,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.franceBarony = CulturalTitleName.CreateBarony(
            "franceBarony",
            france,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.franceLordship = CulturalTitleName.CreateLordship(
            "franceLordship",
            france,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.francePrince = CulturalTitleName.CreatePrince(
            "francePrince",
            france,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.franceKnight = CulturalTitleName.CreateKnight(
            "franceKnight",
            france,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.gealicEmpire = CulturalTitleName.CreateEmpire(
            "gealicEmpire",
            gealic,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.gealicKingdom = CulturalTitleName.CreateKingdom(
            "gealicKingdom",
            gealic,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.gealicDuchy = CulturalTitleName.CreateDuchy(
            "gealicDuchy",
            gealic,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.gealicCounty = CulturalTitleName.CreateCounty(
            "gealicCounty",
            gealic,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.gealicBarony = CulturalTitleName.CreateBarony(
            "gealicBarony",
            gealic,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.gealicLordship = CulturalTitleName.CreateLordship(
            "gealicLordship",
            gealic,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.gealicPrince = CulturalTitleName.CreatePrince(
            "gealicPrince",
            gealic,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.gealicKnight = CulturalTitleName.CreateKnight(
            "gealicKnight",
            gealic,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.georgiaEmpire = CulturalTitleName.CreateEmpire(
            "georgiaEmpire",
            georgia,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.georgiaKingdom = CulturalTitleName.CreateKingdom(
            "georgiaKingdom",
            georgia,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.georgiaDuchy = CulturalTitleName.CreateDuchy(
            "georgiaDuchy",
            georgia,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.georgiaCounty = CulturalTitleName.CreateCounty(
            "georgiaCounty",
            georgia,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.georgiaBarony = CulturalTitleName.CreateBarony(
            "georgiaBarony",
            georgia,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.georgiaLordship = CulturalTitleName.CreateLordship(
            "georgiaLordship",
            georgia,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.georgiaPrince = CulturalTitleName.CreatePrince(
            "georgiaPrince",
            georgia,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.georgiaKnight = CulturalTitleName.CreateKnight(
            "georgiaKnight",
            georgia,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.germanicEmpire = CulturalTitleName.CreateEmpire(
            "germanicEmpire",
            germanic,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.germanicKingdom = CulturalTitleName.CreateKingdom(
            "germanicKingdom",
            germanic,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.germanicDuchy = CulturalTitleName.CreateDuchy(
            "germanicDuchy",
            germanic,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.germanicCounty = CulturalTitleName.CreateCounty(
            "germanicCounty",
            germanic,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.germanicBarony = CulturalTitleName.CreateBarony(
            "germanicBarony",
            germanic,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.germanicLordship = CulturalTitleName.CreateLordship(
            "germanicLordship",
            germanic,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.germanicPrince = CulturalTitleName.CreatePrince(
            "germanicPrince",
            germanic,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.germanicKnight = CulturalTitleName.CreateKnight(
            "germanicKnight",
            germanic,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.andalusEmpire = CulturalTitleName.CreateEmpire(
            "andalusEmpire",
            andalus,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.andalusKingdom = CulturalTitleName.CreateKingdom(
            "andalusKingdom",
            andalus,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.andalusDuchy = CulturalTitleName.CreateDuchy(
            "andalusDuchy",
            andalus,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.andalusCounty = CulturalTitleName.CreateCounty(
            "andalusCounty",
            andalus,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.andalusBarony = CulturalTitleName.CreateBarony(
            "andalusBarony",
            andalus,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.andalusLordship = CulturalTitleName.CreateLordship(
            "andalusLordship",
            andalus,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.andalusPrince = CulturalTitleName.CreatePrince(
            "andalusPrince",
            andalus,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.andalusKnight = CulturalTitleName.CreateKnight(
            "andalusKnight",
            andalus,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.greekEmpire = CulturalTitleName.CreateEmpire(
            "greekEmpire",
            greek,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.greekKingdom = CulturalTitleName.CreateKingdom(
            "greekKingdom",
            greek,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.greekDuchy = CulturalTitleName.CreateDuchy(
            "greekDuchy",
            greek,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.greekCounty = CulturalTitleName.CreateCounty(
            "greekCounty",
            greek,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.greekBarony = CulturalTitleName.CreateBarony(
            "greekBarony",
            greek,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.greekLordship = CulturalTitleName.CreateLordship(
            "greekLordship",
            greek,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.greekPrince = CulturalTitleName.CreatePrince(
            "greekPrince",
            greek,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.greekKnight = CulturalTitleName.CreateKnight(
            "greekKnight",
            greek,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.halychEmpire = CulturalTitleName.CreateEmpire(
            "halychEmpire",
            halych,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.halychKingdom = CulturalTitleName.CreateKingdom(
            "halychKingdom",
            halych,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.halychDuchy = CulturalTitleName.CreateDuchy(
            "halychDuchy",
            halych,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.halychCounty = CulturalTitleName.CreateCounty(
            "halychCounty",
            halych,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.halychBarony = CulturalTitleName.CreateBarony(
            "halychBarony",
            halych,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.halychLordship = CulturalTitleName.CreateLordship(
            "halychLordship",
            halych,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.halychPrince = CulturalTitleName.CreatePrince(
            "halychPrince",
            halych,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.halychKnight = CulturalTitleName.CreateKnight(
            "halychKnight",
            halych,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.hungarianEmpire = CulturalTitleName.CreateEmpire(
            "hungarianEmpire",
            hungarian,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.hungarianKingdom = CulturalTitleName.CreateKingdom(
            "hungarianKingdom",
            hungarian,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.hungarianDuchy = CulturalTitleName.CreateDuchy(
            "hungarianDuchy",
            hungarian,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.hungarianCounty = CulturalTitleName.CreateCounty(
            "hungarianCounty",
            hungarian,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.hungarianBarony = CulturalTitleName.CreateBarony(
            "hungarianBarony",
            hungarian,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.hungarianLordship = CulturalTitleName.CreateLordship(
            "hungarianLordship",
            hungarian,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.hungarianPrince = CulturalTitleName.CreatePrince(
            "hungarianPrince",
            hungarian,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.hungarianKnight = CulturalTitleName.CreateKnight(
            "hungarianKnight",
            hungarian,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.ilkhanidEmpire = CulturalTitleName.CreateEmpire(
            "ilkhanidEmpire",
            ilkhanid,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.ilkhanidKingdom = CulturalTitleName.CreateKingdom(
            "ilkhanidKingdom",
            ilkhanid,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.ilkhanidDuchy = CulturalTitleName.CreateDuchy(
            "ilkhanidDuchy",
            ilkhanid,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.ilkhanidCounty = CulturalTitleName.CreateCounty(
            "ilkhanidCounty",
            ilkhanid,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.ilkhanidBarony = CulturalTitleName.CreateBarony(
            "ilkhanidBarony",
            ilkhanid,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.ilkhanidLordship = CulturalTitleName.CreateLordship(
            "ilkhanidLordship",
            ilkhanid,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.ilkhanidPrince = CulturalTitleName.CreatePrince(
            "ilkhanidPrince",
            ilkhanid,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.ilkhanidKnight = CulturalTitleName.CreateKnight(
            "ilkhanidKnight",
            ilkhanid,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.italianEmpire = CulturalTitleName.CreateEmpire(
            "italianEmpire",
            italian,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.italianKingdom = CulturalTitleName.CreateKingdom(
            "italianKingdom",
            italian,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.italianDuchy = CulturalTitleName.CreateDuchy(
            "italianDuchy",
            italian,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.italianCounty = CulturalTitleName.CreateCounty(
            "italianCounty",
            italian,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.italianBarony = CulturalTitleName.CreateBarony(
            "italianBarony",
            italian,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.italianLordship = CulturalTitleName.CreateLordship(
            "italianLordship",
            italian,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.italianPrince = CulturalTitleName.CreatePrince(
            "italianPrince",
            italian,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.italianKnight = CulturalTitleName.CreateKnight(
            "italianKnight",
            italian,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.latinEmpire = CulturalTitleName.CreateEmpire(
            "latinEmpire",
            latin,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.latinKingdom = CulturalTitleName.CreateKingdom(
            "latinKingdom",
            latin,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.latinDuchy = CulturalTitleName.CreateDuchy(
            "latinDuchy",
            latin,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.latinCounty = CulturalTitleName.CreateCounty(
            "latinCounty",
            latin,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.latinBarony = CulturalTitleName.CreateBarony(
            "latinBarony",
            latin,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.latinLordship = CulturalTitleName.CreateLordship(
            "latinLordship",
            latin,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.latinPrince = CulturalTitleName.CreatePrince(
            "latinPrince",
            latin,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.latinKnight = CulturalTitleName.CreateKnight(
            "latinKnight",
            latin,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.darshiEmpire = CulturalTitleName.CreateEmpire(
            "darshiEmpire",
            darshi,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.darshiKingdom = CulturalTitleName.CreateKingdom(
            "darshiKingdom",
            darshi,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.darshiDuchy = CulturalTitleName.CreateDuchy(
            "darshiDuchy",
            darshi,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.darshiCounty = CulturalTitleName.CreateCounty(
            "darshiCounty",
            darshi,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.darshiBarony = CulturalTitleName.CreateBarony(
            "darshiBarony",
            darshi,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.darshiLordship = CulturalTitleName.CreateLordship(
            "darshiLordship",
            darshi,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.darshiPrince = CulturalTitleName.CreatePrince(
            "darshiPrince",
            darshi,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.darshiKnight = CulturalTitleName.CreateKnight(
            "darshiKnight",
            darshi,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.cumanEmpire = CulturalTitleName.CreateEmpire(
            "cumanEmpire",
            cuman,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.cumanKingdom = CulturalTitleName.CreateKingdom(
            "cumanKingdom",
            cuman,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.cumanDuchy = CulturalTitleName.CreateDuchy(
            "cumanDuchy",
            cuman,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.cumanCounty = CulturalTitleName.CreateCounty(
            "cumanCounty",
            cuman,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.cumanBarony = CulturalTitleName.CreateBarony(
            "cumanBarony",
            cuman,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.cumanLordship = CulturalTitleName.CreateLordship(
            "cumanLordship",
            cuman,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.cumanPrince = CulturalTitleName.CreatePrince(
            "cumanPrince",
            cuman,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.cumanKnight = CulturalTitleName.CreateKnight(
            "cumanKnight",
            cuman,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.genoaEmpire = CulturalTitleName.CreateEmpire(
            "genoaEmpire",
            genoa,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.genoaKingdom = CulturalTitleName.CreateKingdom(
            "genoaKingdom",
            genoa,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.genoaDuchy = CulturalTitleName.CreateDuchy(
            "genoaDuchy",
            genoa,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.genoaCounty = CulturalTitleName.CreateCounty(
            "genoaCounty",
            genoa,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.genoaBarony = CulturalTitleName.CreateBarony(
            "genoaBarony",
            genoa,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.genoaLordship = CulturalTitleName.CreateLordship(
            "genoaLordship",
            genoa,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.genoaPrince = CulturalTitleName.CreatePrince(
            "genoaPrince",
            genoa,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.genoaKnight = CulturalTitleName.CreateKnight(
            "genoaKnight",
            genoa,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.santiagoEmpire = CulturalTitleName.CreateEmpire(
            "santiagoEmpire",
            santiago,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.santiagoKingdom = CulturalTitleName.CreateKingdom(
            "santiagoKingdom",
            santiago,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.santiagoDuchy = CulturalTitleName.CreateDuchy(
            "santiagoDuchy",
            santiago,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.santiagoCounty = CulturalTitleName.CreateCounty(
            "santiagoCounty",
            santiago,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.santiagoBarony = CulturalTitleName.CreateBarony(
            "santiagoBarony",
            santiago,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.santiagoLordship = CulturalTitleName.CreateLordship(
            "santiagoLordship",
            santiago,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.santiagoPrince = CulturalTitleName.CreatePrince(
            "santiagoPrince",
            santiago,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.santiagoKnight = CulturalTitleName.CreateKnight(
            "santiagoKnight",
            santiago,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.templarEmpire = CulturalTitleName.CreateEmpire(
            "templarEmpire",
            templar,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.templarKingdom = CulturalTitleName.CreateKingdom(
            "templarKingdom",
            templar,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.templarDuchy = CulturalTitleName.CreateDuchy(
            "templarDuchy",
            templar,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.templarCounty = CulturalTitleName.CreateCounty(
            "templarCounty",
            templar,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.templarBarony = CulturalTitleName.CreateBarony(
            "templarBarony",
            templar,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.templarLordship = CulturalTitleName.CreateLordship(
            "templarLordship",
            templar,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.templarPrince = CulturalTitleName.CreatePrince(
            "templarPrince",
            templar,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.templarKnight = CulturalTitleName.CreateKnight(
            "templarKnight",
            templar,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.samiEmpire = CulturalTitleName.CreateEmpire(
            "samiEmpire",
            sami,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.samiKingdom = CulturalTitleName.CreateKingdom(
            "samiKingdom",
            sami,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.samiDuchy = CulturalTitleName.CreateDuchy(
            "samiDuchy",
            sami,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.samiCounty = CulturalTitleName.CreateCounty(
            "samiCounty",
            sami,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.samiBarony = CulturalTitleName.CreateBarony(
            "samiBarony",
            sami,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.samiLordship = CulturalTitleName.CreateLordship(
            "samiLordship",
            sami,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.samiPrince = CulturalTitleName.CreatePrince(
            "samiPrince",
            sami,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.samiKnight = CulturalTitleName.CreateKnight(
            "samiKnight",
            sami,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.nizariEmpire = CulturalTitleName.CreateEmpire(
            "nizariEmpire",
            nizari,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.nizariKingdom = CulturalTitleName.CreateKingdom(
            "nizariKingdom",
            nizari,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.nizariDuchy = CulturalTitleName.CreateDuchy(
            "nizariDuchy",
            nizari,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.nizariCounty = CulturalTitleName.CreateCounty(
            "nizariCounty",
            nizari,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.nizariBarony = CulturalTitleName.CreateBarony(
            "nizariBarony",
            nizari,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.nizariLordship = CulturalTitleName.CreateLordship(
            "nizariLordship",
            nizari,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.nizariPrince = CulturalTitleName.CreatePrince(
            "nizariPrince",
            nizari,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.nizariKnight = CulturalTitleName.CreateKnight(
            "nizariKnight",
            nizari,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.lazarusEmpire = CulturalTitleName.CreateEmpire(
            "lazarusEmpire",
            lazarus,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.lazarusKingdom = CulturalTitleName.CreateKingdom(
            "lazarusKingdom",
            lazarus,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.lazarusDuchy = CulturalTitleName.CreateDuchy(
            "lazarusDuchy",
            lazarus,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.lazarusCounty = CulturalTitleName.CreateCounty(
            "lazarusCounty",
            lazarus,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.lazarusBarony = CulturalTitleName.CreateBarony(
            "lazarusBarony",
            lazarus,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.lazarusLordship = CulturalTitleName.CreateLordship(
            "lazarusLordship",
            lazarus,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.lazarusPrince = CulturalTitleName.CreatePrince(
            "lazarusPrince",
            lazarus,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.lazarusKnight = CulturalTitleName.CreateKnight(
            "lazarusKnight",
            lazarus,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.catharsEmpire = CulturalTitleName.CreateEmpire(
            "catharsEmpire",
            cathars,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.catharsKingdom = CulturalTitleName.CreateKingdom(
            "catharsKingdom",
            cathars,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.catharsDuchy = CulturalTitleName.CreateDuchy(
            "catharsDuchy",
            cathars,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.catharsCounty = CulturalTitleName.CreateCounty(
            "catharsCounty",
            cathars,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.catharsBarony = CulturalTitleName.CreateBarony(
            "catharsBarony",
            cathars,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.catharsLordship = CulturalTitleName.CreateLordship(
            "catharsLordship",
            cathars,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.catharsPrince = CulturalTitleName.CreatePrince(
            "catharsPrince",
            cathars,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.catharsKnight = CulturalTitleName.CreateKnight(
            "catharsKnight",
            cathars,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.hospitallerEmpire = CulturalTitleName.CreateEmpire(
            "hospitallerEmpire",
            hospitaller,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.hospitallerKingdom = CulturalTitleName.CreateKingdom(
            "hospitallerKingdom",
            hospitaller,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.hospitallerDuchy = CulturalTitleName.CreateDuchy(
            "hospitallerDuchy",
            hospitaller,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.hospitallerCounty = CulturalTitleName.CreateCounty(
            "hospitallerCounty",
            hospitaller,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.hospitallerBarony = CulturalTitleName.CreateBarony(
            "hospitallerBarony",
            hospitaller,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.hospitallerLordship = CulturalTitleName.CreateLordship(
            "hospitallerLordship",
            hospitaller,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.hospitallerPrince = CulturalTitleName.CreatePrince(
            "hospitallerPrince",
            hospitaller,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.hospitallerKnight = CulturalTitleName.CreateKnight(
            "hospitallerKnight",
            hospitaller,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.mongolianEmpire = CulturalTitleName.CreateEmpire(
            "mongolianEmpire",
            mongolian,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.mongolianKingdom = CulturalTitleName.CreateKingdom(
            "mongolianKingdom",
            mongolian,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.mongolianDuchy = CulturalTitleName.CreateDuchy(
            "mongolianDuchy",
            mongolian,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.mongolianCounty = CulturalTitleName.CreateCounty(
            "mongolianCounty",
            mongolian,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.mongolianBarony = CulturalTitleName.CreateBarony(
            "mongolianBarony",
            mongolian,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.mongolianLordship = CulturalTitleName.CreateLordship(
            "mongolianLordship",
            mongolian,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.mongolianPrince = CulturalTitleName.CreatePrince(
            "mongolianPrince",
            mongolian,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.mongolianKnight = CulturalTitleName.CreateKnight(
            "mongolianKnight",
            mongolian,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.norwegianEmpire = CulturalTitleName.CreateEmpire(
            "norwegianEmpire",
            norwegian,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.norwegianKingdom = CulturalTitleName.CreateKingdom(
            "norwegianKingdom",
            norwegian,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.norwegianDuchy = CulturalTitleName.CreateDuchy(
            "norwegianDuchy",
            norwegian,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.norwegianCounty = CulturalTitleName.CreateCounty(
            "norwegianCounty",
            norwegian,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.norwegianBarony = CulturalTitleName.CreateBarony(
            "norwegianBarony",
            norwegian,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.norwegianLordship = CulturalTitleName.CreateLordship(
            "norwegianLordship",
            norwegian,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.norwegianPrince = CulturalTitleName.CreatePrince(
            "norwegianPrince",
            norwegian,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.norwegianKnight = CulturalTitleName.CreateKnight(
            "norwegianKnight",
            norwegian,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.polandEmpire = CulturalTitleName.CreateEmpire(
            "polandEmpire",
            poland,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.polandKingdom = CulturalTitleName.CreateKingdom(
            "polandKingdom",
            poland,
            new TextObject(english ? "King" : "Król"),
            new TextObject(english ? "Queen" : "Królowa"),
            new TextObject(english ? "Kingdom" : "Królestwo"));

            this.polandDuchy = CulturalTitleName.CreateDuchy(
            "polandDuchy",
            poland,
            new TextObject(english ? "Duke" : "Książe"),
            new TextObject(english ? "Duchess" : "Księżna"),
            new TextObject(english ? "Duchy" : "Księstwo"));

            this.polandCounty = CulturalTitleName.CreateCounty(
            "polandCounty",
            poland,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.polandBarony = CulturalTitleName.CreateBarony(
            "polandBarony",
            poland,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.polandLordship = CulturalTitleName.CreateLordship(
            "polandLordship",
            poland,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.polandPrince = CulturalTitleName.CreatePrince(
            "polandPrince",
            poland,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.polandKnight = CulturalTitleName.CreateKnight(
            "polandKnight",
            poland,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.portugueseEmpire = CulturalTitleName.CreateEmpire(
            "portugueseEmpire",
            portuguese,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.portugueseKingdom = CulturalTitleName.CreateKingdom(
            "portugueseKingdom",
            portuguese,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.portugueseDuchy = CulturalTitleName.CreateDuchy(
            "portugueseDuchy",
            portuguese,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.portugueseCounty = CulturalTitleName.CreateCounty(
            "portugueseCounty",
            portuguese,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.portugueseBarony = CulturalTitleName.CreateBarony(
            "portugueseBarony",
            portuguese,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.portugueseLordship = CulturalTitleName.CreateLordship(
            "portugueseLordship",
            portuguese,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.portuguesePrince = CulturalTitleName.CreatePrince(
            "portuguesePrince",
            portuguese,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.portugueseKnight = CulturalTitleName.CreateKnight(
            "portugueseKnight",
            portuguese,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.rusEmpire = CulturalTitleName.CreateEmpire(
            "rusEmpire",
            rus,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.rusKingdom = CulturalTitleName.CreateKingdom(
            "rusKingdom",
            rus,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.rusDuchy = CulturalTitleName.CreateDuchy(
            "rusDuchy",
            rus,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.rusCounty = CulturalTitleName.CreateCounty(
            "rusCounty",
            rus,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.rusBarony = CulturalTitleName.CreateBarony(
            "rusBarony",
            rus,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.rusLordship = CulturalTitleName.CreateLordship(
            "rusLordship",
            rus,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.rusPrince = CulturalTitleName.CreatePrince(
            "rusPrince",
            rus,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.rusKnight = CulturalTitleName.CreateKnight(
            "rusKnight",
            rus,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.scottishEmpire = CulturalTitleName.CreateEmpire(
            "scottishEmpire",
            scottish,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.scottishKingdom = CulturalTitleName.CreateKingdom(
            "scottishKingdom",
            scottish,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.scottishDuchy = CulturalTitleName.CreateDuchy(
            "scottishDuchy",
            scottish,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.scottishCounty = CulturalTitleName.CreateCounty(
            "scottishCounty",
            scottish,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.scottishBarony = CulturalTitleName.CreateBarony(
            "scottishBarony",
            scottish,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.scottishLordship = CulturalTitleName.CreateLordship(
            "scottishLordship",
            scottish,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.scottishPrince = CulturalTitleName.CreatePrince(
            "scottishPrince",
            scottish,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.scottishKnight = CulturalTitleName.CreateKnight(
            "scottishKnight",
            scottish,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.serbiaEmpire = CulturalTitleName.CreateEmpire(
            "serbiaEmpire",
            serbia,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.serbiaKingdom = CulturalTitleName.CreateKingdom(
            "serbiaKingdom",
            serbia,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.serbiaDuchy = CulturalTitleName.CreateDuchy(
            "serbiaDuchy",
            serbia,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.serbiaCounty = CulturalTitleName.CreateCounty(
            "serbiaCounty",
            serbia,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.serbiaBarony = CulturalTitleName.CreateBarony(
            "serbiaBarony",
            serbia,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.serbiaLordship = CulturalTitleName.CreateLordship(
            "serbiaLordship",
            serbia,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.serbiaPrince = CulturalTitleName.CreatePrince(
            "serbiaPrince",
            serbia,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.serbiaKnight = CulturalTitleName.CreateKnight(
            "serbiaKnight",
            serbia,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.swedenEmpire = CulturalTitleName.CreateEmpire(
            "swedenEmpire",
            sweden,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.swedenKingdom = CulturalTitleName.CreateKingdom(
            "swedenKingdom",
            sweden,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.swedenDuchy = CulturalTitleName.CreateDuchy(
            "swedenDuchy",
            sweden,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.swedenCounty = CulturalTitleName.CreateCounty(
            "swedenCounty",
            sweden,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.swedenBarony = CulturalTitleName.CreateBarony(
            "swedenBarony",
            sweden,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.swedenLordship = CulturalTitleName.CreateLordship(
            "swedenLordship",
            sweden,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.swedenPrince = CulturalTitleName.CreatePrince(
            "swedenPrince",
            sweden,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.swedenKnight = CulturalTitleName.CreateKnight(
            "swedenKnight",
            sweden,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.teutonicEmpire = CulturalTitleName.CreateEmpire(
            "teutonicEmpire",
            teutonic,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.teutonicKingdom = CulturalTitleName.CreateKingdom(
            "teutonicKingdom",
            teutonic,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.teutonicDuchy = CulturalTitleName.CreateDuchy(
            "teutonicDuchy",
            teutonic,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.teutonicCounty = CulturalTitleName.CreateCounty(
            "teutonicCounty",
            teutonic,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.teutonicBarony = CulturalTitleName.CreateBarony(
            "teutonicBarony",
            teutonic,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.teutonicLordship = CulturalTitleName.CreateLordship(
            "teutonicLordship",
            teutonic,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.teutonicPrince = CulturalTitleName.CreatePrince(
            "teutonicPrince",
            teutonic,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.teutonicKnight = CulturalTitleName.CreateKnight(
            "teutonicKnight",
            teutonic,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.turkishEmpire = CulturalTitleName.CreateEmpire(
            "turkishEmpire",
            turkish,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.turkishKingdom = CulturalTitleName.CreateKingdom(
            "turkishKingdom",
            turkish,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.turkishDuchy = CulturalTitleName.CreateDuchy(
            "turkishDuchy",
            turkish,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.turkishCounty = CulturalTitleName.CreateCounty(
            "turkishCounty",
            turkish,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.turkishBarony = CulturalTitleName.CreateBarony(
            "turkishBarony",
            turkish,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.turkishLordship = CulturalTitleName.CreateLordship(
            "turkishLordship",
            turkish,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.turkishPrince = CulturalTitleName.CreatePrince(
            "turkishPrince",
            turkish,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.turkishKnight = CulturalTitleName.CreateKnight(
            "turkishKnight",
            turkish,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            this.walesEmpire = CulturalTitleName.CreateEmpire(
            "walesEmpire",
            wales,
            new TextObject(english ? "Emperor" : "Emperor"),
            new TextObject(english ? "Empress" : "Empress"),
            new TextObject(english ? "Empire" : "Empire"));

            this.walesKingdom = CulturalTitleName.CreateKingdom(
            "walesKingdom",
            wales,
            new TextObject(english ? "King" : "King"),
            new TextObject(english ? "Queen" : "Queen"),
            new TextObject(english ? "Kingdom" : "Kingdom"));

            this.walesDuchy = CulturalTitleName.CreateDuchy(
            "walesDuchy",
            wales,
            new TextObject(english ? "Duke" : "Duke"),
            new TextObject(english ? "Duchess" : "Duchess"),
            new TextObject(english ? "Duchy" : "Duchy"));

            this.walesCounty = CulturalTitleName.CreateCounty(
            "walesCounty",
            wales,
            new TextObject(english ? "Count" : "Count"),
            new TextObject(english ? "Countess" : "Countess"),
            new TextObject(english ? "County" : "County"));

            this.walesBarony = CulturalTitleName.CreateBarony(
            "walesBarony",
            wales,
            new TextObject(english ? "Baron" : "Baron"),
            new TextObject(english ? "Baroness" : "Baroness"),
            new TextObject(english ? "Barony" : "Barony"));

            this.walesLordship = CulturalTitleName.CreateLordship(
            "walesLordship",
            wales,
            new TextObject(english ? "Lord" : "Lord"),
            new TextObject(english ? "Lady" : "Lady"),
            new TextObject(english ? "Lordship" : "Lordship"));

            this.walesPrince = CulturalTitleName.CreatePrince(
            "walesPrince",
            wales,
            new TextObject(english ? "Prince" : "Prince"),
            new TextObject(english ? "Princess" : "Princess"),
            new TextObject(english ? "Princes" : "Princes"));

            this.walesKnight = CulturalTitleName.CreateKnight(
            "walesKnight",
            wales,
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knight" : "Knight"),
            new TextObject(english ? "Knights" : "Knights"));

            foreach (CulturalTitleName name in this.All)
            {
                DefaultTypeInitializer<DefaultTitleNames, CulturalTitleName>.Instance.AddObject(name);
            }
        }
    }
}
