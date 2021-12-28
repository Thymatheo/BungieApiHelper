using System.Collections.Generic;

namespace BungieApiHelper.Entity.GroupsV2
{
    public class GroupFeatures
    {
        public int maximumMembers { get; set; }
        /// <summary>
        /// <para>Maximum number of groups of this type a typical membership may join.</para>
        /// <para>For example, a user may join about 50 General groups with their Bungie.net account. </para>
        /// <para>They may join one clan per Destiny membership.</para>
        /// </summary>
        public int maximumMembershipsOfGroupType { get; set; }
        public int capabilities { get; set; }
        public IEnumerable<int> membershipTypes { get; set; }
        /// <summary>
        /// <para>Minimum Member Level allowed to invite new members to group</para>
        /// <para>Always Allowed: Founder, Acting Founder</para>
        /// <para>True means admins have this power, false means they don't</para>
        /// <para>Default is false for clans, true for groups.</para>
        /// </summary>
        public bool invitePermissionOverride { get; set; }
        /// <summary>
        /// <para>Minimum Member Level allowed to invite new members to group</para>
        /// <para>Always Allowed: Founder, Acting Founder</para>
        /// <para>True means admins have this power, false means they don't</para>
        /// <para>Default is false for clans, true for groups.</para>
        /// </summary>
        public bool updateCulturePermissionOverride { get; set; }
        /// <summary>
        /// <para>Minimum Member Level allowed to invite new members to group</para>
        /// <para>Always Allowed: Founder, Acting Founder</para>
        /// <para>True means admins have this power, false means they don't</para>
        /// <para>Default is false for clans, true for groups.</para>
        /// </summary>
        public int hostGuidedGamePermissionOverride { get; set; }
        /// <summary>
        /// <para>Minimum Member Level allowed to invite new members to group</para>
        /// <para>Always Allowed: Founder, Acting Founder</para>
        /// <para>True means admins have this power, false means they don't</para>
        /// <para>Default is false for clans, true for groups.</para>
        /// </summary>
        public bool updateBannerPermissionOverride { get; set; }
        /// <summary>
        /// <para>Level to join a member at when accepting an invite, application, or joining an open clan</para>
        /// <para>Default is Beginner.</para>
        /// </summary>
        public int joinLevel { get; set; }
    }
}