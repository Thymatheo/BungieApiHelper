using BungieApiHelper.Entity.Entities.Items;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Components {
    public class DestinyPlatformSilverComponent {
        /// <summary>
        /// If a Profile is played on multiple platforms, this is the silver they have for each platform, keyed by Membership Type.
        /// </summary>
        public Dictionary<int, DestinyItemComponent> platformSilver { get; set; }
    }
}
