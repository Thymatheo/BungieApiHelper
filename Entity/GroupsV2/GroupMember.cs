using BungieApiHelper.Entity.User;
using System;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupMember {
        public int memberType { get; set; }
        public bool isOnline { get; set; }
        public int lastOnlineStatusChange { get; set; }
        public int groupId { get; set; }
        public GroupUserInfoCard destinyUserInfo { get; set; }
        public UserInfoCard bungieNetUserInfo { get; set; }
        public DateTime joinDate { get; set; }
    }
}