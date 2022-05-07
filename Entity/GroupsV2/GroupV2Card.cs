using System;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupV2Card {
        public int groupId { get; set; }
        public string name { get; set; }
        public int groupType { get; set; }
        public DateTime creationDate { get; set; }
        public string about { get; set; }
        public string motto { get; set; }
        public string memberCount { get; set; }
        public string locale { get; set; }
        public int membershipOption { get; set; }
        public int capabilities { get; set; }
        public GroupV2ClanInfo clanInfo { get; set; }
        public string avatarPath { get; set; }
        public string theme { get; set; }

    }
}
