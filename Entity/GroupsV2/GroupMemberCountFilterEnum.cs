﻿using System.Text.Json.Serialization;

namespace BungieApiHelper
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GroupMemberCountFilterEnum
    {
        All = 0,
        OneToTen = 1,
        ElevenToOneHundred = 2,
        GreaterThanOneHundred = 3
    }
}