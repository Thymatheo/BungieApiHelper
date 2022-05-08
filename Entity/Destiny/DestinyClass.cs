using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Destiny {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DestinyClass {
        Titan = 0,
        Hunter = 1,
        Warlock = 2,
        Unknown = 3
    }
}
