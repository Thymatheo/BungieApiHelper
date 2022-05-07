namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupOptionalConversationEditRequest {
        public bool? chatEnabled { get; set; }
        public string chatName { get; set; }
        public ChatSecurityEnum chatSecurity { get; set; }
    }
}
