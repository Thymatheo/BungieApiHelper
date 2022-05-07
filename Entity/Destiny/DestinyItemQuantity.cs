namespace BungieApiHelper.Entity.Destiny {
    public class DestinyItemQuantity {
        /// <summary>
        /// The hash identifier for the item in question. Use it to look up the item's DestinyInventoryItemDefinition.
        /// </summary>
        public int itemHash { get; set; }
        /// <summary>
        /// If this quantity is referring to a specific instance of an item, this will have the item's instance ID. Normally, this will be null.
        /// </summary>
        public int? itemInstanceId { get; set; }
        /// <summary>
        /// The amount of the item needed/available depending on the context of where DestinyItemQuantity is being used.
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// Indicates that this item quantity may be conditionally shown or hidden, based on various sources of state. For example: server flags, account state, or character progress.
        /// </summary>
        public bool hasConditionalVisibility { get; set; }
    }
}
