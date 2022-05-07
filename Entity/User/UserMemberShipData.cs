using BungieApiHelper.Entity.GroupsV2;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.User {
    public class UserMemberShipData {
        /// <summary>
        /// this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)
        /// </summary>
        public IEnumerable<GroupUserInfoCard> destinyMemberships { get; set; }
        /// <summary>
        /// If this property is populated, it will have the membership ID of the account considered to be "primary" in this user's cross save relationship.
        /// <para>
        /// If null, this user has no cross save relationship, nor primary account.
        /// </para>
        /// </summary>
        public string? primaryMembershipId { get; set; }
        public GeneralUser bungieNetUser { get; set; }

    }
}
