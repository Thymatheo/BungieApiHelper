using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.Bungie
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BungieMembershipType
    {
        None = 0,
        TigerXbox = 1,
        TigerPsn = 2,
        TigerSteam = 3,
        TigerBlizzard = 4,
        TigerStadia = 5,
        TigerDemon = 10,
        BungieNext = 254,
        All = -1
    }
}
