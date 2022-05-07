using System.Collections.Generic;

namespace BungieApiHelper.Entity.Components.Kiosks {
    public class DestinyKiosksComponent {
        /// <summary>
        /// A dictionary keyed by the Kiosk Vendor's hash identifier (use it to look up the DestinyVendorDefinition for the relevant kiosk vendor), and whose value is a list of all the items that the user can "see" in the Kiosk, and any other interesting metadata.
        /// </summary>
        public Dictionary<int, IEnumerable<int>> kioskItems { get; set; }
    }
}
