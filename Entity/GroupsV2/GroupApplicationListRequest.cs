using BungieApiHelper.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupApplicationListRequest : GroupApplicationRequest {
        public IEnumerable<UserMembership> memberships { get; set; }
    }
}
