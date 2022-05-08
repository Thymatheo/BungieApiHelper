using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Destiny {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DestinyRace {
        Human = 0,
        Awoken = 1,
        Exo = 2,
        Unknown = 3,
    }
}
