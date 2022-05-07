using BungieApiHelper.Entity.User;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Responses {
    public class DestinyLinkedProfilesResponse {
        public IEnumerable<DestinyProfileUserInfoCard> profiles { get; set; }
        public UserInfoCard bnetMembership { get; set; }
        public IEnumerable<DestinyErrorProfile> profilesWithErrors { get; set; }
    }
}
