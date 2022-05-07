using BungieApiHelper.Entity.Quests;
using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Entities.Items {
    public class DestinyItemComponent {
        /// <summary>
        /// The identifier for the item's definition, which is where most of the useful static information for the item can be found.
        /// </summary>
        public int itemHash { get; set; }
        /// <summary>
        /// If the item is instanced, it will have an instance ID. Lack of an instance ID implies that the item has no distinct local qualities aside from stack size.
        /// </summary>
        public int itemInstanceId { get; set; }
        /// <summary>
        /// The quantity of the item in this stack. Note that Instanced items cannot stack. If an instanced item, this value will always be 1 (as the stack has exactly one item in it)
        /// </summary>
        public int quantity { get; set; }
        /// <summary>
        /// If the item is bound to a location, it will be specified in this enum.
        /// </summary>
        public int bindStatus { get; set; }
        /// <summary>
        /// An easy reference for where the item is located. Redundant if you got the item from an Inventory, but useful when making detail calls on specific items.
        /// </summary>
        public int location { get; set; }
        /// <summary>
        /// The hash identifier for the specific inventory bucket in which the item is located.
        /// </summary>
        public int bucketHash { get; set; }
        /// <summary>
        /// If there is a known error state that would cause this item to not be transferable, this Flags enum will indicate all of those error states. Otherwise, it will be 0 (CanTransfer).
        /// </summary>
        public int transferStatus { get; set; }
        /// <summary>
        /// If the item can be locked, this will indicate that state.
        /// </summary>
        public bool lockable { get; set; }
        /// <summary>
        /// A flags enumeration indicating the transient/custom states of the item that affect how it is rendered: whether it's tracked or locked for example, or whether it has a masterwork plug inserted.
        /// </summary>
        public int state { get; set; }
        /// <summary>
        /// If populated, this is the hash of the item whose icon (and other secondary styles, but *not* the human readable strings) should override whatever icons/styles are on the item being sold.
        /// </summary>
        public int overrideStyleItemHash { get; set; }
        /// <summary>
        /// If the item can expire, this is the date at which it will/did expire.
        /// </summary>
        public DateTime expirationDate { get; set; }
        /// <summary>
        /// If this is true, the object is actually a "wrapper" of the object it's representing. This means that it's not the actual item itself, but rather an item that must be "opened" in game before you have and can use the item.
        /// </summary>
        public bool isWrapper { get; set; }
        /// <summary>
        /// If this is populated, it is a list of indexes into DestinyInventoryItemDefinition.tooltipNotifications for any special tooltip messages that need to be shown for this item.
        /// </summary>
        public IEnumerable<int> tooltipNotificationIndexes { get; set; }
        /// <summary>
        /// The identifier for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        public int metricHash { get; set; }
        /// <summary>
        /// The objective progress for the currently-selected metric definition, to be displayed on the emblem nameplate.
        /// </summary>
        public DestinyObjectiveProgress metricObjective { get; set; }
        /// <summary>
        /// The version of this item, used to index into the versions list in the item definition quality block.
        /// </summary>
        public int? versionNumber { get; set; }
        /// <summary>
        /// If available, a list that describes which item values (rewards) should be shown (true) or hidden (false).
        /// </summary>
        public IEnumerable<bool> itemValueVisibility { get; set; }

    }
}
