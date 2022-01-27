using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Config;
using BungieApiHelper.Entity.GroupsV2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper
{
    public class GroupV2Helper : BasicHelper
    {
        public GroupV2Helper() : base("GroupV2") { }

        /// <summary>
        /// Returns a list of all available group avatars for the signed-in user.
        /// </summary>
        public async Task<BasicResponse<Dictionary<int, string>>> GetAvailableAvatars() =>
            await Get<Dictionary<int, string>>("GetAvailableAvatars");

        /// <summary>
        /// Returns a list of all available group themes.
        /// </summary>
        public async Task<BasicResponse<IEnumerable<GroupTheme>>> GetAvailableThemes() =>
            await Get<IEnumerable<GroupTheme>>("GetAvailableThemes");

        /// <summary>
        /// Search for Groups.
        /// </summary>
        /// <param name="content"></param>
        public async Task<BasicResponse<GroupSearchResponse>> Search(GroupQuery content) =>
            await Post<GroupSearchResponse>($"Search", content);

        /// <summary>
        /// Get information about a specific group of the given ID.
        /// </summary>
        /// <param name="groupId">Requested group's id.</param>
        public async Task<BasicResponse<GroupResponse>> Get(int groupId) =>
            await Get<GroupResponse>($"{groupId}");

        /// <summary>
        /// Get information about a specific group with the given name and type.
        /// </summary>
        /// <param name="groupName">Exact name of the group to find.</param>
        /// <param name="groupType">Type of group to find.</param>
        public async Task<BasicResponse<GroupResponse>> Name(string groupName, int groupType) =>
            await Get<GroupResponse>($"Name/{groupName}/{groupType}");

        /// <summary>
        /// Get information about a specific group with the given name and type. The POST version.
        /// </summary>
        public async Task<BasicResponse<GroupResponse>> NameV2(GroupNameSearchRequest content) =>
            await Post<GroupResponse>($"NameV2", content);

        /// <summary>
        /// Get information about a specific group with the given name and type. The POST version.
        /// </summary>
        /// <param name="groupId">Requested group's id.</param>
        public async Task<BasicResponse<IEnumerable<GroupOptionalConversation>>> OptionalConversations(int groupId) =>
            await Get<IEnumerable<GroupOptionalConversation>>($"{groupId}/OptionalConversations");

        /// <summary>
        /// Get the list of members in a given group.
        /// </summary>
        /// <param name="groupId">The ID of the group.</param>
        /// <param name="currentpage">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="memberType">Filter out other member types. Use None for all members.</param>
        /// <param name="nameSearch">The name fragment upon which a search should be executed for members with matching display or unique names.</param>
        public async Task<BasicResponse<SearchResultOfGroupMember>> Members(int groupId,int currentpage, int memberType, string nameSearch) =>
            await Get<SearchResultOfGroupMember>($"{groupId}/Members/{currentpage}", BuildQueryParam(new List<QueryParam>() { new QueryParam() { Label = "memberType", Value = memberType }, new QueryParam() { Label = "nameSearch", Value = nameSearch } }));

        /// <summary>
        /// Get the list of members in a given group who are of admin level or higher.
        /// </summary>
        /// <param name="groupId">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="currentpage">The ID of the group.</param>
        public async Task<BasicResponse<SearchResultOfGroupMember>> AdminsAndFounder(int groupId,int currentpage) =>
            await Get<SearchResultOfGroupMember>($"{groupId}/AdminsAndFounder/{currentpage}");
    }
}
