using BungieApiHelper.Entity.Destiny;
using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Vendors {
    public class DestinyVendorReceipt {
        /// <summary>
        /// The amount paid for the item, in terms of items that were consumed in the purchase and their quantity.
        /// </summary>
        public IEnumerable<DestinyItemQuantity> currencyPaid { get; set; }
        /// <summary>
        /// The item that was received, and its quantity.
        /// </summary>
        public DestinyItemQuantity itemReceived { get; set; }
        /// <summary>
        /// The unlock flag used to determine whether you still have the purchased item.
        /// </summary>
        public int licenseUnlockHash { get; set; }
        /// <summary>
        /// The ID of the character who made the purchase.
        /// </summary>
        public int purchasedByCharacterId { get; set; }
        /// <summary>
        /// Whether you can get a refund, and what happens in order for the refund to be received. See the DestinyVendorItemRefundPolicy enum for details.
        /// </summary>
        public int refundPolicy { get; set; }
        /// <summary>
        /// The identifier of this receipt.
        /// </summary>
        public int sequenceNumber { get; set; }
        /// <summary>
        /// The seconds since epoch at which this receipt is rendered invalid.
        /// </summary>
        public int timeToExpiration { get; set; }
        /// <summary>
        /// The date at which this receipt is rendered invalid.
        /// </summary>
        public DateTime expiresOn { get; set; }

    }
}
