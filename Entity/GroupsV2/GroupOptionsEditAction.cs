namespace BungieApiHelper.Entity.GroupsV2 {
    public class GroupOptionsEditAction {
        public bool InvitePermissionOverride { get; set; }
        public bool UpdateCulturePermissionOverride { get; set; }
        public HostGuidedGamePermissionOverrideEnum HostGuidedGamePermissionOverride { get; set; }
        public bool UpdateBannerPermissionOverride { get; set; }
        public JoinLevelEnum JoinLevel { get; set; }
    }
}
