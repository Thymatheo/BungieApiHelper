using BungieApiHelper.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupBan {
        public int groupId { get; set; }
        public UserInfoCard lastModifiedBy { get; set; }
        public UserInfoCard createdBy { get; set; }
        public DateTime dateBanned { get; set; }
        public DateTime dateExpires { get; set; }
        public string comment { get; set; }
        public UserInfoCard bungieNetUserInfo { get; set; }
        public GroupUserInfoCard destinyUserInfo { get; set; }
    }
}
