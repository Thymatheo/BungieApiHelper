using BungieApiHelper.Entity.Destiny;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.GroupsV2
{
    public class GroupV2ClanInfoAndInvestment
    {
        public Dictionary<int, DestinyProgression> d2ClanProgressions { get; set; }
        public string clanCallsign { get; set; }
        public ClanBanner clanBannerData { get; set; }
    }
}