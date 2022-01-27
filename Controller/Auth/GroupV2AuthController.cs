using BungieApiHelper.Auth.Controller;
using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.GroupsV2;
using BungieApiHelper.Helper;
using BungieApiHelper.Helper.Auth;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller.Auth
{
    [ApiExplorerSettings(IgnoreApi = false)]
    public class GroupV2AuthController : BasicAuthController<GroupV2AuthHelper>
    {

        /// <summary>
        /// Gets the state of the user's clan invite preferences for a particular membership type - true if they wish to be invited to clans, false otherwise.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadUserData
        /// </remarks>
        /// <param name="mType">The Destiny membership type of the account we wish to access settings.</param>
        [HttpGet("GetUserClanInviteSetting/{mType}")]
        public async Task<ActionResult<BasicResponse<bool>>> GetUserClanInviteSetting([FromRoute] BungieMembershipType mType)
        {
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
        public async Task<ActionResult<BasicResponse<bool>>> Recommended([FromRoute] int groupType, [FromRoute] int createDateRange)
        {
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
        public async Task<ActionResult<BasicResponse<int>>> Edit([FromRoute] int groupId, [FromBody] GroupEditAction content)
        {
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
        public async Task<ActionResult<BasicResponse<int>>> EditClanBanner([FromRoute] int groupId, [FromBody] ClanBanner content)
        {
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
        public async Task<ActionResult<BasicResponse<int>>> EditFounderOptions([FromRoute] int groupId, [FromBody] GroupOptionsEditAction content)
        {
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
        public async Task<ActionResult<BasicResponse<int>>> AddOptionalConversation([FromRoute] int groupId, [FromBody] GroupOptionalConversationAddRequest content)
        {
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
        public async Task<ActionResult<BasicResponse<int>>> EditOptionalConversation([FromRoute] int groupId, [FromRoute]int conversationId,[FromBody] GroupOptionalConversationEditRequest content)
        {
            return Ok(await _helper.EditOptionalConversation(groupId, conversationId, content));
        }
    }
}
