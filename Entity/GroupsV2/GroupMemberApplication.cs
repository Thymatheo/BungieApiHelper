using BungieApiHelper.Entity.User;
using System;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupMemberApplication {
        public int groupId { get; set; }
        public DateTime creationDate { get; set; }
        public int resolveState { get; set; }
        public DateTime? resolveDate { get; set; }
        public int? resolvedByMembershipId { get; set; }
        public string requestMessage { get; set; }
        public string resolveMessage { get; set; }
        public GroupUserInfoCard destinyUserInfo { get; set; }
        public UserInfoCard bungieNetUserInfo { get; set; }
    }
}
