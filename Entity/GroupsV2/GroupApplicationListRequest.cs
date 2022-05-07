using BungieApiHelper.Entity.User;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupApplicationListRequest : GroupApplicationRequest {
        public IEnumerable<UserMembership> memberships { get; set; }
    }
}
