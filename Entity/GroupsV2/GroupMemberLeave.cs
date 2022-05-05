using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupMemberLeave {
        public GroupV2 group { get; set; }
        public bool groupDeleted { get; set; }
    }
}
