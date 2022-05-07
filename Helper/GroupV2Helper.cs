using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Config;
using BungieApiHelper.Entity.GroupsV2;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper {
    public class GroupV2Helper : BasicHelper {
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
        public async Task<BasicResponse<SearchResultOfGroupMember>> Members(int groupId, int currentpage, int memberType, string nameSearch) =>
            await Get<SearchResultOfGroupMember>($"{groupId}/Members/{currentpage}", queryParam: BuildQueryParam(new() { new() { Label = "memberType", Value = memberType }, new() { Label = "nameSearch", Value = nameSearch } }));

        /// <summary>
        /// Get the list of members in a given group who are of admin level or higher.
        /// </summary>
        /// <param name="groupId">Page number (starting with 1). Each page has a fixed size of 50 items per page.</param>
        /// <param name="currentpage">The ID of the group.</param>
        public async Task<BasicResponse<SearchResultOfGroupMember>> AdminsAndFounder(int groupId, int currentpage) =>
            await Get<SearchResultOfGroupMember>($"{groupId}/AdminsAndFounder/{currentpage}");
        /// <summary>
        /// Allows a founder to manually recover a group they can see in game but not on bungie.net
        /// </summary>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param>
        /// <param name="groupType">Type of group the supplied member founded.</param>
        public async Task<BasicResponse<GetGroupsForMemberResponse>> GetGroupsForMember(int membershipType, int membershipId, int filter, int groupType) =>
            await Get<GetGroupsForMemberResponse>($"User/{membershipType}/{membershipId}/{filter}/{groupType}/");
        /// <summary>
        /// Allows a founder to manually recover a group they can see in game but not on bungie.net
        /// </summary>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <param name="membershipId">Membership ID to for which to find founded groups.</param>
        /// <param name="groupType">Type of group the supplied member founded.</param>
        public async Task<BasicResponse<GroupMembershipSearchResponse>> RecoverGroupForFounder(int membershipType, int membershipId, int groupType) =>
            await Get<GroupMembershipSearchResponse>($"Recover/{membershipType}/{membershipId}/{groupType}/");
        /// <summary>
        /// Get information about the groups that a given member has applied to or been invited to.
        /// </summary>
        /// <param name="membershipType">Membership type of the supplied membership ID.</param>
        /// <param name="membershipId">Membership ID to for which to find applied groups.</param>
        /// <param name="filter">Filter apply to list of potential joined groups.</param>
        /// <param name="groupType">Type of group the supplied member applied.</param>
        public async Task<BasicResponse<GroupPotentialMembershipSearchResponse>> GetPotentialGroupsForMember(int membershipType, int membershipId, int filter, int groupType) =>
            await Get<GroupPotentialMembershipSearchResponse>($"User/Potentia/{membershipType}/{membershipId}/{filter}/{groupType}/");
    }
}
