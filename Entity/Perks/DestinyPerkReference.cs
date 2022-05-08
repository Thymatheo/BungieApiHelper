using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Perks {
    public class DestinyPerkReference {
        /// <summary>
        /// The hash identifier for the perk, which can be used to look up DestinySandboxPerkDefinition if it exists.
        /// </summary>
        /// <remarks>
        /// Be warned, perks frequently do not have user-viewable information. 
        /// <para>
        /// You should examine whether you actually found a name/description in the perk's definition before you show it to the user.
        /// </para>
        /// </remarks>
        public int perkHash { get; set; }
        /// <summary>
        /// The icon for the perk.
        /// </summary>
        public string iconPath { get; set; }
        /// <summary>
        /// Whether this perk is currently active.
        /// </summary>
        /// <remarks>
        /// (We may return perks that you have not actually activated yet: these represent perks that you should show in the item's tooltip, but that the user has not yet activated.)
        /// </remarks>
        public bool isActive { get; set; }
        /// <summary>
        /// Some perks provide benefits, but aren't visible in the UI.
        /// </summary>
        /// <remarks>
        /// This value will let you know if this is perk should be shown in your UI.
        /// </remarks>
        public bool visible { get; set; }
    }
}
