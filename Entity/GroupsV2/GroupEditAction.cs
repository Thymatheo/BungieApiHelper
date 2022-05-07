namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupEditAction {
        public string name { get; set; }
        public string about { get; set; }
        public string motto { get; set; }
        public string theme { get; set; }
        public int? avatarImageIndex { get; set; }
        public string tags { get; set; }
        public bool? isPublic { get; set; }
        public MembershipOptionEnum? membershipOption { get; set; }
        public bool? isPublicTopicAdminOnly { get; set; }
        public bool? allowChat { get; set; }
        public ChatSecurityEnum? chatSecurity { get; set; }
        public string callsign { get; set; }
        public string locale { get; set; }
        public HomepageEnum? homepage { get; set; }
        public bool? enableInvitationMessagingForAdmins { get; set; }
        public DefaultPublicityEnum? defaultPublicity { get; set; }
    }
}
