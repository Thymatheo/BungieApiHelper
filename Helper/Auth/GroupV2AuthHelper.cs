using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.GroupsV2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper.Auth
{
    public class GroupV2AuthHelper : BasicAuthHelper
    {
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
        public async Task<BasicResponse<int>> SetMembershipType(int groupId, int membershipType, int membershipId, int memberType) =>
            await Post<int>($"{groupId}/Members/{membershipType}/{membershipId}/SetMembershipType/{memberType}", null);
    }
}
