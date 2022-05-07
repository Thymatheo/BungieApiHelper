using System.Collections.Generic;

namespace BungieApiHelper.Entity.Components.PlugSets {
    public class DestinyPlugSetsComponent {
#warning need to check the format with Destiny.Definitions.Sockets.DestinyPlugSetDefinition
        public Dictionary<int, IEnumerable<object>> plugs { get; set; }
    }
}
