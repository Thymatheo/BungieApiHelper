﻿using BungieApiHelper.Entity.Unspecified.SingleComponentResponseOf;

namespace BungieApiHelper.Entity.Responses {
    public class DestinyProfileResponse {
        /// <summary>
        /// Recent, refundable purchases you have made from vendors. When will you use it? Couldn't say...
        /// </summary>
        public SingleComponentResponseOfDestinyVendorReceiptsComponent vendorReceipts { get; set; }
        /// <summary>
        /// The profile-level inventory of the Destiny Profile.
        /// </summary>
        public SingleComponentResponseOfDestinyInventoryComponent profileInventory { get; set; }
        /// <summary>
        /// The profile-level currencies owned by the Destiny Profile.
        /// </summary>
        public SingleComponentResponseOfDestinyInventoryComponent profileCurrencies { get; set; }
        /// <summary>
        /// The basic information about the Destiny Profile (formerly "Account").
        /// </summary>
        public SingleComponentResponseOfDestinyProfileComponent profile { get; set; }
        /// <summary>
        /// Silver quantities for any platform on which this Profile plays destiny.
        /// </summary>
        public SingleComponentResponseOfDestinyPlatformSilverComponent platformSilver { get; set; }
        /// <summary>
        /// tems available from Kiosks that are available Profile-wide (i.e. across all characters)
        /// </summary>
        /// <remarks>
        /// This component returns information about what Kiosk items are available to you on a *Profile* level.
        /// <para>
        /// It is theoretically possible for Kiosks to have items gated by specific Character as well. 
        /// </para>
        /// <para>
        /// If you ever have those, you will find them on the characterKiosks property.
        /// </para>
        /// </remarks>
        public SingleComponentResponseOfDestinyKiosksComponent profileKiosks { get; set; }
        public SingleComponentResponseOfDestinyPlugSetsComponent profilePlugSets { get; set; }

    }
}
