using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupV2 {
        public int groupId { get; set; }
        public string name { get; set; }
        public int groupType { get; set; }
        public int membershipIdCreated { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modificationDate { get; set; }
        public string about { get; set; }
        public IEnumerable<string> tags { get; set; }
        public int memberCount { get; set; }
        public bool isPublic { get; set; }
        public bool isPublicTopicAdminOnly { get; set; }
        public string motto { get; set; }
        public bool allowChat { get; set; }
        public bool isDefaultPostPublic { get; set; }
        public int chatSecurity { get; set; }
        public string locale { get; set; }
        public int avatarImageIndex { get; set; }
        public int homepage { get; set; }
        public int membershipOption { get; set; }
        public int defaultPublicity { get; set; }
        public string theme { get; set; }
        public string bannerPath { get; set; }
        public string avatarPath { get; set; }
        public int conversationId { get; set; }
        public bool enableInvitationMessagingForAdmins { get; set; }
        public DateTime? banExpireDate { get; set; }
        public GroupFeatures features { get; set; }
        public GroupV2ClanInfoAndInvestment clanInfo { get; set; }
    }
}
