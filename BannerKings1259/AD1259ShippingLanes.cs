using System;
using System.Collections.Generic;
using System.Linq;
using BannerKings;
using BannerKings.Managers.Shipping;
using TaleWorlds.CampaignSystem.Settlements;
using TaleWorlds.Localization;

namespace BannerKings1259.ShippingLanes
{
    internal class AD1259ShippingLanes: DefaultTypeInitializer<AD1259ShippingLanes, ShippingLane>
    {
        public ShippingLane HanseaticLeague { get; } = new ShippingLane("Hanseatic League");

        public override IEnumerable<ShippingLane> All
        {
            get
            {
                yield return HanseaticLeague;
            }
        }

        public override void Initialize()
        {
            /*HanseaticLeague.Initialize(new TextObject("Hanseatic League"),
                new TextObject(),
                new List<Settlement>()
                {
                    Settlement.All.First(x => x.StringId == "town_hamburg"),
                    Settlement.All.First(x => x.StringId == "town_gdansk")
                });
            foreach (var l in All)
            {
                DefaultShippingLanes.Instance.AddObject(l);
            }*/
        }
    }
}
