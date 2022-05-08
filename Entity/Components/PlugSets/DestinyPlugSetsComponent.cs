using BungieApiHelper.Entity.Definition.Sockets;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Components.PlugSets {
    public class DestinyPlugSetsComponent {
        public Dictionary<int, IEnumerable<DestinyPlugSetDefinition>> plugs { get; set; }
    }
}
