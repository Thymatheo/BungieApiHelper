﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupMembership {
        public GroupMember member { get; set; }
        public GroupV2 group { get; set; }
    }
}
