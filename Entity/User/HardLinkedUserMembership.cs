namespace BungieApiHelper.Entity.User {
    public class HardLinkedUserMembership {
        public int membershipType { get; set; }
        public string membershipId { get; set; }
        public int CrossSaveOverriddenType { get; set; }
        public int? CrossSaveOverriddenMembershipId { get; set; }
    }
}
