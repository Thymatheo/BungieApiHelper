using BungieApiHelper.Entity.Vendors;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Entities.Profiles {
    public class DestinyVendorReceiptsComponent {
        public IEnumerable<DestinyVendorReceipt> receipts { get; set; }
    }
}
