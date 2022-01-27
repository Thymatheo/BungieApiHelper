using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Config;
using BungieApiHelper.Entity.User;
using BungieApiHelper.Entity.User.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper
{
    public class UserHelper : BasicHelper
    {
        /// <summary>
        /// Default Contructor for the UserHelper
        /// </summary>
        public UserHelper() : base("User") { }

        /// <summary>
        /// Loads a bungienet user by membership id.
        /// </summary>
        /// <param name="id">The requested Bungie.net membership id.</param>
        public async Task<BasicResponse<GeneralUser>> GetBungieNetUserById(int id) =>
            await Get<GeneralUser>($"GetBungieNetUserById/{id}");

        /// <summary>
        /// Returns a list of all available user themes.
        /// </summary>
        public async Task<BasicResponse<IEnumerable<UserTheme>>> GetAvailableThemes() =>
            await Get<IEnumerable<UserTheme>>($"GetAvailableThemes");

        /// <summary>
        /// Returns a list of accounts associated with the supplied membership ID and membership type.
        /// </summary>
        /// <remarks>
        /// The types of membership the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.MembershipType.
        /// <para> 
        /// This will include all linked accounts (even when hidden) if supplied credentials permit it.
        /// </para>
        /// </remarks>
        /// <param name="membershipId">The membership ID of the target user.</param>
        /// <param name="membershipType">Type of the supplied membership ID.</param>
        public async Task<BasicResponse<UserMemberShipData>> GetMembershipsById(int membershipId, BungieMembershipType membershipType) =>
            await Get<UserMemberShipData>($"GetMembershipsById/{membershipId}/{(int)membershipType}");

        /// <summary>
        /// Gets any hard linked membership given a credential.
        /// </summary>
        /// <remarks>
        /// Only works for credentials that are public (just SteamID64 right now). Cross Save aware.
        /// <para>
        /// The types of credentials the Accounts system supports. This is the external facing enum used in place of the internal-only Bungie.SharedDefinitions.CredentialType.
        /// </para>
        /// </remarks>
        /// <param name="credential">The credential to look up. Must be a valid SteamID64.</param>
        /// <param name="crType">The credential type. 'SteamId' is the only valid value at present.</param>
        public async Task<BasicResponse<HardLinkedUserMembership>> GetMembershipFromHardLinkedCredential(string credential, BungieCredentialType crType) =>
            await Get<HardLinkedUserMembership>($"GetMembershipFromHardLinkedCredential/{(byte)crType}/{credential}");

        /// <summary>
        /// Allow to search user by entering a prefix of the username
        /// </summary>
        /// <param name="displayNamePrefix">The display name prefix you're looking for.</param>
        /// <param name="page">The zero-based page of results you desire.</param>
        [Obsolete("Do not use this to search users, use SearchByGlobalNamePost instead")]
        public async Task<BasicResponse<UserSearchResponse>> SearchByGlobalNamePrefix(string displayNamePrefix, int page) =>
            await Get<UserSearchResponse>($"Search/Prefix/{displayNamePrefix}/{page}");
        /// <summary>
        /// Given the prefix of a global display name, returns all users who share that name.
        /// </summary>
        /// <param name="content">Contain the data for the research query</param>
        /// <param name="page">The zero-based page of results you desire.</param>
        public async Task<BasicResponse<UserSearchResponse>> SearchByGlobalNamePost(UserSearchPrefixRequest content, int page = 0) =>
            await Post<UserSearchResponse>($"Search/GlobalName/{page}", content);
    }
}
