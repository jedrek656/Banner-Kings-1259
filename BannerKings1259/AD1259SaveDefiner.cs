using BannerKings.Managers.Institutions.Religions.Faiths.Groups;
using BannerKings1259.Faiths;
using BannerKings1259.Religions;
using BannerKings1259.Religions.Faiths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.SaveSystem;

namespace BannerKings1259
{
    public class AD1259SaveDefiner : SaveableTypeDefiner
    {
        public AD1259SaveDefiner() : base(83828293)
        {
        }

        protected override void DefineClassTypes()
        {
            
            AddClassDefinition(typeof(CatholicFaith), 1);
            AddClassDefinition(typeof(ArmenianCatholicFaith), 2);
            AddClassDefinition(typeof(OrthodoxFaith), 3);
            AddClassDefinition(typeof(KrstjaniFaith), 4);
            AddClassDefinition(typeof(CatharFaith), 5);
            AddClassDefinition(typeof(SunnicFaith), 6);
            AddClassDefinition(typeof(ShiaFaith), 7);
            AddClassDefinition(typeof(JudaismFaith), 8);
            AddClassDefinition(typeof(TengrismFaith), 9);
            AddClassDefinition(typeof(BuddhistFaith), 10);
            AddClassDefinition(typeof(RomuvaFaith), 11);
            AddClassDefinition(typeof(SaamiShamanismFaith), 12);

            AddClassDefinition(typeof(CatholicFaithGroup), 13);
        }

        protected override void DefineContainerDefinitions()
        {
        }
    }
}
