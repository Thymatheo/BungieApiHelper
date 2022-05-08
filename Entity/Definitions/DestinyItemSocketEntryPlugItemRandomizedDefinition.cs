using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Definition {
    public class DestinyItemSocketEntryPlugItemRandomizedDefinition {
        public object craftingRequirements { get; set; }
        /// <summary>
        /// Indicates if the plug can be rolled on the current version of the item. For example, older versions of weapons may have plug rolls that are no longer possible on the current versions.
        /// </summary>
        public bool currentlyCanRoll { get; set; }
        /// <summary>
        /// The hash identifier of a DestinyInventoryItemDefinition representing the plug that can be inserted.
        /// </summary>
        public int plugItemHash { get; set; }
    }
}
