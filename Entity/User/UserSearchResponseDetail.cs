using System.Collections.Generic;

namespace BungieApiHelper.Entity.User {
    public class UserSearchResponseDetail {
        public string bungieGlobalDisplayName { get; set; }
        public int bungieGlobalDisplayNameCode { get; set; }
        public string? bungieNetMembershipId { get; set; }
        public IEnumerable<UserInfoCard> destinyMemberships { get; set; }
    }
}