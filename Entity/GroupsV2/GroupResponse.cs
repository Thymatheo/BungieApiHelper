using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.GroupsV2
{
    public class GroupResponse
    {
        public GroupV2 detail { get; set; }
        public GroupMember founder { get; set; }
        public IEnumerable<int> alliedIds { get; set; }
        public GroupV2 parentGroup { get; set; }
        public int allianceStatus { get; set; }
        public int groupJoinInviteCount { get; set; }

        /// <summary>
        /// A convenience property that indicates if every membership you (the current user) have that is a part of this group are part of an account that is considered inactive - for example, overridden accounts in Cross Save.
        /// </summary>
        public bool currentUserMembershipsInactiveForDestiny { get; set; }
        /// <summary>
        /// <para>This property will be populated if the authenticated user is a member of the group.</para>
        /// <para>Note that because of account linking, a user can sometimes be part of a clan more than once.</para>
        /// <para>As such, this returns the highest member type available.</para>
        /// </summary>
        public Dictionary<int, GroupMember> currentUserMemberMap { get; set; }
        /// <summary>
        /// <para>This property will be populated if the authenticated user is an applicant or has an outstanding invitation to join.</para>
        /// <para>Note that because of account linking, a user can sometimes be part of a clan more than once.</para>
        /// </summary>
        public Dictionary<int, GroupPotentialMember> currentUserPotentialMemberMap { get; set; }

    }
}
