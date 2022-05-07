using BungieApiHelper.Entity.Entities.Items;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Entities.Inventory {
    public class DestinyInventoryComponent {
        public IEnumerable<DestinyItemComponent> items { get; set; }
    }
}
