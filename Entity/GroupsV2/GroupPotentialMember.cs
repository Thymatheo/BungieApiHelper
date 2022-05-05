using BungieApiHelper.Entity.User;
using System;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupPotentialMember {
        public int potentialStatus { get; set; }
        public int groupId { get; set; }
        public GroupUserInfoCard destinyUserInfo { get; set; }
        public UserInfoCard bungieNetUserInfo { get; set; }
        public DateTime joinDate { get; set; }
    }
}