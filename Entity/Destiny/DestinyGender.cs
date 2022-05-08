using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BungieApiHelper.Entity.Destiny {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DestinyGender {
        Male = 0,
        Female = 1,
        Unknown = 2
    }
}
