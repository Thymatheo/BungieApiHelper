﻿using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.Bungie {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BungieUnpairedGameVersions {
        None = 0,
        Destiny2 = 1,
        DLC1 = 2,
        DLC2 = 4,
        Forsaken = 8,
        YearTwoAnnualPass = 16,
        Shadowkeep = 32,
        BeyondLight = 64,
        Anniversary30th = 128,
        TheWitchQueen = 256,
    }
}
