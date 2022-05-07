namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupOptionalConversation {
        public int groupId { get; set; }
        public int conversationId { get; set; }
        public bool chatEnabled { get; set; }
        public string chatName { get; set; }
        public int chatSecurity { get; set; }
    }
}
