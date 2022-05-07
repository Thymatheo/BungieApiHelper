using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Entities;
using BungieApiHelper.Entity.GroupsV2;
using BungieApiHelper.Entity.Unspecified.SearchResultOf;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper.Auth {
    public class GroupV2AuthHelper : BasicAuthHelper {
        public GroupV2AuthHelper() : base("GroupV2") { }

        /// <summary>
        /// Gets the state of the user's clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadUserData
        /// </remarks>
        /// <param name="mType">The Destiny membership type of the account we wish to access settings.</param>
        public async Task<BasicResponse<bool>> GetUserClanInviteSetting(BungieMembershipType mType) =>
            await Get<bool>($"GetUserClanInviteSetting/{(int)mType}");

        /// <summary>
        /// Gets groups recommended for you based on the groups to whom those you follow belong.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadGroups
        /// </remarks>
        /// <param name="groupType">Type of groups requested</param>
        /// <param name="createDateRange">Requested range in which to pull recommended groups</param>
        public async Task<BasicResponse<IEnumerable<GroupV2Card>>> Recommended(int groupType, int createDateRange) =>
            await Post<IEnumerable<GroupV2Card>>($"Recommended/{groupType}/{createDateRange}", null);

        /// <summary>
        /// Edit an existing group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// <para>
        /// You must have suitable permissions in the group to perform this operation.
        /// </para>
        /// <para>
        /// This latest revision will only edit the fields you pass in - pass null for properties you want to leave unaltered.
        /// </para>
        /// </remarks>
        /// <param name="groupId">Requested group's id.</param>
        public async Task<BasicResponse<int>> Edit(int groupId, GroupEditAction content) =>
            await Post<int>($"{groupId}/Edit", content);

        /// <summary>
        /// Edit an existing group's clan banner.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// <para>
        /// You must have suitable permissions in the group to perform this operation.
        /// </para>
        /// <para>
        /// All fields are required.
        /// </para>
        /// </remarks>
        /// <param name="groupId">Group ID of the group to edit.</param>
        public async Task<BasicResponse<int>> EditClanBanner(int groupId, ClanBanner content) =>
            await Post<int>($"{groupId}/EditClanBanner", content);

        /// <summary>
        /// Edit an existing group's clan banner. 
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// <para>
        /// You must have suitable permissions in the group to perform this operation.
        /// </para>
        /// <para>
        /// All fields are required.
        /// </para>
        /// </remarks>
        /// <param name="groupId">Group ID of the group to edit.</param>
        public async Task<BasicResponse<int>> EditFounderOptions(int groupId, GroupOptionsEditAction content) =>
            await Post<int>($"{groupId}/EditFounderOptions", content);

        /// <summary>
        /// Add a new optional conversation/chat channel. 
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// <para>
        /// Requires admin permissions to the group.
        /// </para>
        /// </remarks>
        /// <param name="groupId">Group ID of the group to edit.</param>
        public async Task<BasicResponse<int>> AddOptionalConversation(int groupId, GroupOptionalConversationAddRequest content) =>
            await Post<int>($"{groupId}/OptionalConversations/Add", content);

        /// <summary>
        /// Edit the settings of an optional conversation/chat channel.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// <para>
        /// Requires admin permissions to the group.
        /// </para>
        /// </remarks>
        /// <param name="groupId">Group ID of the group to edit.</param>
        /// <param name="conversationId">Conversation Id of the channel being edited.</param>
        public async Task<BasicResponse<int>> EditOptionalConversation(int groupId, int conversationId, GroupOptionalConversationEditRequest content) =>
            await Post<int>($"{groupId}/OptionalConversations/Edit/{conversationId}", content);

        /// <summary>
        /// Edit the membership type of a given member.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// <para>
        /// You must have suitable permissions in the group to perform this operation.
        /// </para>
        /// </remarks>
        /// <param name="groupId">ID of the group to which the member belongs.</param>
        /// <param name="membershipType">Membership ID to modify.</param>
        /// <param name="membershipId">Membership type of the provide membership ID.</param>
        /// <param name="memberType">New membertype for the specified member.</param>
        public async Task<BasicResponse<int>> SetMembershipType(int groupId, BungieMembershipType membershipType, int membershipId, int memberType) =>
            await Post<int>($"{groupId}/Members/{membershipType}/{membershipId}/SetMembershipType/{memberType}", null);

        /// <summary>
        /// Kick a member from the given group, forcing them to reapply if they wish to re-join the group. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID to kick the user from.</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <param name="membershipId">Membership ID to kick.</param>
        public async Task<BasicResponse<GroupMemberLeave>> KickMembers(int groupId, BungieMembershipType membershipType, int membershipId) =>
            await Post<GroupMemberLeave>($"{groupId}/Members/{membershipType}/{membershipId}/Kick", null);

        /// <summary>
        /// Bans the requested member from the requested group for the specified period of time.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID to kick the user from.</param>
        /// <param name="membershipType">Membership ID of the member to ban from the group.</param>
        /// <param name="membershipId">Membership type of the provided membership ID.</param>
        public async Task<BasicResponse<int>> BanMembers(int groupId, BungieMembershipType membershipType, int membershipId) =>
            await Post<int>($"{groupId}/Members/{membershipType}/{membershipId}/Ban", null);

        /// <summary>
        /// Bans the requested member from the requested group for the specified period of time.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID to kick the user from.</param>
        /// <param name="membershipType">Membership ID of the member to ban from the group.</param>
        /// <param name="membershipId">Membership type of the provided membership ID.</param>
        public async Task<BasicResponse<int>> UnBanMembers(int groupId, BungieMembershipType membershipType, int membershipId) =>
            await Post<int>($"{groupId}/Members/{membershipType}/{membershipId}/Unban", null);
        /// <summary>
        /// Get the list of banned members in a given group. Only accessible to group Admins and above. Not applicable to all groups. Check group features.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID whose banned members you are fetching</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 entries.</param>
        public async Task<BasicResponse<SearchResultOfGroupBan>> GetBannedMembersOfGroup(int groupId, int currentpage = 1) =>
            await Get<SearchResultOfGroupBan>($"{groupId}/Banned", $"?currentpage={currentpage}");

        /// <summary>
        /// An administrative method to allow the founder of a group or clan to give up their position to another admin permanently.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">The target group id.</param>
        /// <param name="membershipType">Membership type of the provided founderIdNew.</param>
        /// <param name="founderIdNew">The new founder for this group. Must already be a group admin.</param>
        public async Task<BasicResponse<bool>> AbdicateFoundership(int groupId, BungieMembershipType membershipType, int founderIdNew) =>
            await Post<bool>($"{groupId}/Admin/AbdicateFoundership/{membershipType}/{founderIdNew}", null);
        /// <summary>
        /// Get the list of users who are awaiting a decision on their application to join a given group. Modified to include application info.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        public async Task<BasicResponse<SearchResultOfGroupMemberApplication>> GetPendingMemberships(int groupId, int currentpage = 1) =>
            await Get<SearchResultOfGroupMemberApplication>($"{groupId}/Members/Pending", queryParam: BuildQueryParam(new() { new() { Label = "currentpage", Value = currentpage } }));

        /// <summary>
        /// Get the list of users who have been invited into the group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        public async Task<BasicResponse<SearchResultOfGroupMemberApplication>> GetInvitedIndividuals(int groupId, int currentpage = 1) =>
            await Get<SearchResultOfGroupMemberApplication>($"{groupId}/Members/InvitedIndividuals", queryParam: BuildQueryParam(new() { new() { Label = "currentpage", Value = currentpage } }));
        /// <summary>
        /// Approve all of the pending users for the given group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        public async Task<BasicResponse<EntityActionResult>> ApproveAllPending(int groupId, GroupApplicationRequest content) =>
            await Post<EntityActionResult>($"{groupId}/Members/ApproveAll", content);
        /// <summary>
        /// Deny all of the pending users for the given group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        public async Task<BasicResponse<EntityActionResult>> DenyAllPending(int groupId, GroupApplicationRequest content) =>
            await Post<EntityActionResult>($"{groupId}/Members/DenyAll", content);
        /// <summary>
        /// Approve all of the pending users for the given group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        public async Task<BasicResponse<EntityActionResult>> ApprovePendingForList(int groupId, GroupApplicationListRequest content) =>
            await Post<EntityActionResult>($"{groupId}/Members/ApproveList", content);
        /// <summary>
        /// Approve the given membershipId to join the group/clan as long as they have applied.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <param name="membershipId">The membership id being approved.</param>
        /// <param name="content"></param>
        public async Task<BasicResponse<EntityActionResult>> ApprovePending(int groupId, BungieMembershipType membershipType, int membershipId, GroupApplicationRequest content) =>
            await Post<EntityActionResult>($"{groupId}/Members/Approve/{membershipType}/{membershipId}", content);
        /// <summary>
        /// Deny all of the pending users for the given group that match the passed-in.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        public async Task<BasicResponse<EntityActionResult>> DenyPendingForList(int groupId, GroupApplicationListRequest content) =>
            await Post<EntityActionResult>($"{groupId}/Members/DenyList", content);
        /// <summary>
        /// Invite a user to join this group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group you would like to join.</param>
        /// <param name="membershipType">Membership id of the account being invited.</param>
        /// <param name="membershipId">MembershipType of the account being invited.</param>
        /// <param name="content"></param>
        public async Task<BasicResponse<GroupApplicationResponse>> IndividualGroupInvite(int groupId, BungieMembershipType membershipType, int membershipId, GroupApplicationRequest content) =>
            await Post<GroupApplicationResponse>($"{groupId}/Members/IndividualInvite/{membershipType}/{membershipId}", content);
        /// <summary>
        /// Cancels a pending invitation to join a group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group you would like to join.</param>
        /// <param name="membershipType">Membership id of the account being cancelled.</param>
        /// <param name="membershipId">MembershipType of the account being cancelled.</param>
        public async Task<BasicResponse<GroupApplicationResponse>> IndividualGroupInviteCancel(int groupId, BungieMembershipType membershipType, int membershipId) =>
            await Post<GroupApplicationResponse>($"{groupId}/Members/IndividualInviteCancel/{membershipType}/{membershipId}", null);
    }
}
