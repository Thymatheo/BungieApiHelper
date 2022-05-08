using BungieApiHelper.Entity.Destiny;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Progression {
    public class DestinyFactionProgression : DestinyProgression {
        /// <summary>
        /// The hash identifier of the Faction related to this progression. Use it to look up the DestinyFactionDefinition for more rendering info.
        /// </summary>
        public int factionHash { get; set; }
        /// <summary>
        /// The index of the Faction vendor that is currently available. Will be set to -1 if no vendors are available.
        /// </summary>
        public int factionVendorIndex { get; set; }
    }
}
