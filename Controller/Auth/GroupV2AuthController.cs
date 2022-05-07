using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Entities;
using BungieApiHelper.Entity.GroupsV2;
using BungieApiHelper.Entity.Unspecified.SearchResultOf;
using BungieApiHelper.Helper.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller.Auth {
    [ApiExplorerSettings(IgnoreApi = false)]
    public class GroupV2AuthController : BasicAuthController<GroupV2AuthHelper> {

        /// <summary>
        /// Gets the state of the user's clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadUserData
        /// </remarks>
        /// <param name="mType">The Destiny membership type of the account we wish to access settings.</param>
        [HttpGet("GetUserClanInviteSetting/{mType}")]
        public async Task<ActionResult<BasicResponse<bool>>> GetUserClanInviteSetting([FromRoute] BungieMembershipType mType) {
            return Ok(await _helper.GetUserClanInviteSetting(mType));
        }

        /// <summary>
        /// Gets groups recommended for you based on the groups to whom those you follow belong.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadGroups
        /// </remarks>
        /// <param name="groupType">Type of groups requested</param>
        /// <param name="createDateRange">Requested range in which to pull recommended groups</param>
        [HttpPost("Recommended/{groupType}/{createDateRange}")]
        public async Task<ActionResult<BasicResponse<bool>>> Recommended([FromRoute] int groupType, [FromRoute] int createDateRange) {
            return Ok(await _helper.Recommended(groupType, createDateRange));
        }

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
        [HttpPost("{groupId}/Edit")]
        public async Task<ActionResult<BasicResponse<int>>> Edit([FromRoute] int groupId, [FromBody] GroupEditAction content) {
            return Ok(await _helper.Edit(groupId, content));
        }

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
        [HttpPost("{groupId}/EditClanBanner")]
        public async Task<ActionResult<BasicResponse<int>>> EditClanBanner([FromRoute] int groupId, [FromBody] ClanBanner content) {
            return Ok(await _helper.EditClanBanner(groupId, content));
        }

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
        [HttpPost("{groupId}/EditFounderOptions")]
        public async Task<ActionResult<BasicResponse<int>>> EditFounderOptions([FromRoute] int groupId, [FromBody] GroupOptionsEditAction content) {
            return Ok(await _helper.EditFounderOptions(groupId, content));
        }

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
        [HttpPost("{groupId}/OptionalConversations/Add/")]
        public async Task<ActionResult<BasicResponse<int>>> AddOptionalConversation([FromRoute] int groupId, [FromBody] GroupOptionalConversationAddRequest content) {
            return Ok(await _helper.AddOptionalConversation(groupId, content));
        }

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
        [HttpPost("{groupId}/OptionalConversations/Edit/{conversationId}/")]
        public async Task<ActionResult<BasicResponse<int>>> EditOptionalConversation([FromRoute] int groupId, [FromRoute] int conversationId, [FromBody] GroupOptionalConversationEditRequest content) {
            return Ok(await _helper.EditOptionalConversation(groupId, conversationId, content));
        }

        /// <summary>
        /// Kick a member from the given group, forcing them to reapply if they wish to re-join the group. You must have suitable permissions in the group to perform this operation.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID to kick the user from.</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <param name="membershipId">Membership ID to kick.</param>
        [HttpPost("{groupId}/Members/{membershipType}/{membershipId}/Kick")]
        public async Task<ActionResult<BasicResponse<GroupMemberLeave>>> KickMembers([FromRoute] int groupId, [FromRoute] BungieMembershipType membershipType, [FromRoute] int membershipId) =>
           Ok(await _helper.KickMembers(groupId, membershipType, membershipId));

        /// <summary>
        /// Bans the requested member from the requested group for the specified period of time.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID to ban the user from.</param>
        /// <param name="membershipType">Membership ID of the member to ban from the group.</param>
        /// <param name="membershipId">Membership type of the provided membership ID.</param>
        [HttpPost("{groupId}/Members/{membershipType}/{membershipId}/Ban")]
        public async Task<ActionResult<BasicResponse<int>>> BanMembers([FromRoute] int groupId, [FromRoute] BungieMembershipType membershipType, [FromRoute] int membershipId) =>
            Ok(await _helper.BanMembers(groupId, membershipType, membershipId));

        /// <summary>
        /// Bans the requested member from the requested group for the specified period of time.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID to unban the user from.</param>
        /// <param name="membershipType">Membership type of the provided membership ID.</param>
        /// <param name="membershipId">Membership ID of the member to unban from the group</param>
        [HttpPost("{groupId}/Members/{membershipType}/{membershipId}/Unban")]
        public async Task<ActionResult<BasicResponse<int>>> UnBanMembers([FromRoute] int groupId, [FromRoute] BungieMembershipType membershipType, [FromRoute] int membershipId) =>
            Ok(await _helper.UnBanMembers(groupId, membershipType, membershipId));

        /// <summary>
        /// Get the list of banned members in a given group. Only accessible to group Admins and above. Not applicable to all groups. Check group features.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">Group ID whose banned members you are fetching</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 entries.</param>
        [HttpGet("{groupId}/Banned")]
        public async Task<ActionResult<BasicResponse<SearchResultOfGroupBan>>> GetBannedMembersOfGroup([FromRoute] int groupId, [FromQuery] int currentpage = 1) =>
            Ok(await _helper.GetBannedMembersOfGroup(groupId, currentpage));


        /// <summary>
        /// An administrative method to allow the founder of a group or clan to give up their position to another admin permanently.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">The target group id.</param>
        /// <param name="membershipType">Membership type of the provided founderIdNew.</param>
        /// <param name="founderIdNew">The new founder for this group. Must already be a group admin.</param>
        [HttpPost("{groupId}/Admin/AbdicateFoundership/{membershipType}/{founderIdNew}")]
        public async Task<ActionResult<BasicResponse<bool>>> AbdicateFoundership([FromRoute] int groupId, [FromRoute] BungieMembershipType membershipType, [FromRoute] int founderIdNew) =>
            Ok(await _helper.AbdicateFoundership(groupId, membershipType, founderIdNew));


        /// <summary>
        /// Get the list of users who are awaiting a decision on their application to join a given group. Modified to include application info.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        [HttpGet("{groupId}/Members/Pending")]
        public async Task<ActionResult<BasicResponse<SearchResultOfGroupMemberApplication>>> GetPendingMemberships([FromRoute] int groupId, [FromQuery] int currentpage = 1) =>
            Ok(await _helper.GetPendingMemberships(groupId, currentpage));
        /// <summary>
        /// Get the list of users who have been invited into the group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks> 
        /// <param name="groupId">ID of the group.</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        [HttpGet("{groupId}/Members/InvitedIndividuals")]
        public async Task<ActionResult<BasicResponse<SearchResultOfGroupMemberApplication>>> GetInvitedIndividuals([FromRoute] int groupId, [FromQuery] int currentpage = 1) =>
            Ok(await _helper.GetInvitedIndividuals(groupId, currentpage));
        /// <summary>
        /// Approve all of the pending users for the given group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        [HttpPost("{groupId}/Members/ApproveAll")]
        public async Task<ActionResult<BasicResponse<EntityActionResult>>> ApproveAllPending([FromRoute] int groupId, [FromBody] GroupApplicationRequest content) =>
            Ok(await _helper.ApproveAllPending(groupId, content));
        /// <summary>
        /// Approve all of the pending users for the given group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        [HttpPost("{groupId}/Members/DenyAll")]
        public async Task<ActionResult<BasicResponse<EntityActionResult>>> DenyAllPending([FromRoute] int groupId, [FromBody] GroupApplicationRequest content) =>
            Ok(await _helper.DenyAllPending(groupId, content));
        /// <summary>
        /// Approve all of the pending users for the given group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        [HttpPost("{groupId}/Members/ApproveList")]
        public async Task<ActionResult<BasicResponse<EntityActionResult>>> ApprovePendingForList([FromRoute] int groupId, [FromBody] GroupApplicationListRequest content) =>
            Ok(await _helper.ApprovePendingForList(groupId, content));
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
        [HttpPost("{groupId}/Members/Approve/{membershipType}/{membershipId}")]
        public async Task<ActionResult<BasicResponse<EntityActionResult>>> ApprovePending([FromRoute] int groupId, [FromRoute] BungieMembershipType membershipType, [FromRoute] int membershipId, [FromBody] GroupApplicationRequest content) =>
           Ok(await _helper.ApprovePending(groupId, membershipType, membershipId, content));


        /// <summary>
        /// Deny all of the pending users for the given group that match the passed-in.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group.</param>
        /// <param name="content"></param>
        [HttpPost("{groupId}/Members/DenyList")]
        public async Task<ActionResult<BasicResponse<EntityActionResult>>> DenyPendingForList([FromRoute] int groupId, [FromBody] GroupApplicationListRequest content) =>
             Ok(await _helper.DenyPendingForList(groupId, content));

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
        [HttpPost("{groupId}/Members/IndividualInvite/{membershipType}/{membershipId}")]
        public async Task<ActionResult<BasicResponse<GroupApplicationResponse>>> IndividualGroupInvite([FromRoute] int groupId, [FromRoute] BungieMembershipType membershipType, [FromRoute] int membershipId, [FromBody] GroupApplicationRequest content) =>
            Ok(await _helper.IndividualGroupInvite(groupId, membershipType, membershipId, content));


        /// <summary>
        /// Cancels a pending invitation to join a group.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : AdminGroups
        /// </remarks>
        /// <param name="groupId">ID of the group you would like to join.</param>
        /// <param name="membershipType">Membership id of the account being cancelled.</param>
        /// <param name="membershipId">MembershipType of the account being cancelled.</param>
        [HttpPost("{groupId}/Members/IndividualInviteCancel/{membershipType}/{membershipId}")]
        public async Task<ActionResult<BasicResponse<GroupApplicationResponse>>> IndividualGroupInviteCancel([FromRoute] int groupId, [FromRoute] BungieMembershipType membershipType, [FromRoute] int membershipId) =>
            Ok(await _helper.IndividualGroupInviteCancel(groupId, membershipType, membershipId));
    }
}
