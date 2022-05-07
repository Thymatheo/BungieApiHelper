using BungieApiHelper.Entity.Unspecified.SearchResultOf;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.GroupsV2 {
    public class GetGroupsForMemberResponse : SearchResultOf<GroupMembership> {
        /// <summary>
        /// The key is the Group ID for the group being checked, and the value is true if the users' memberships for that group are all inactive.
        /// </summary>
        public Dictionary<int, bool> areAllMembershipsInactive { get; set; }
    }
}
