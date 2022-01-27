using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Bungie;
using BungieApiHelper.Entity.Config;
using BungieApiHelper.Entity.User;
using BungieApiHelper.Entity.User.Models;
using BungieApiHelper.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller
{
    [ApiExplorerSettings(IgnoreApi = false)]
    public class UserController : BasicController<UserHelper>
    {
        /// <summary>
        /// Loads a bungienet user by membership id.
        /// </summary>
        /// <param name="id">The requested Bungie.net membership id.</param>
        [HttpGet("GetBungieNetUserById/{id}")]
        public async Task<ActionResult<BasicResponse<GeneralUser>>> GetBungieNetUserById([FromRoute] int id)
        {
            return Ok(await _helper.GetBungieNetUserById(id));
        }

        /// <summary>
        /// Returns a list of all available user themes.
        /// </summary>
        [HttpGet("GetAvailableThemes")]
        public async Task<ActionResult<BasicResponse<IEnumerable<UserTheme>>>> GetAvailableThemes()
        {
            return Ok(await _helper.GetAvailableThemes());
        }

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
        [HttpGet("GetMembershipsById/{membershipId}/{membershipType}")]
        public async Task<ActionResult<BasicResponse<UserMemberShipData>>> GetMembershipsById([FromRoute]int membershipId, [FromRoute]BungieMembershipType membershipType)
        {
            return Ok(await _helper.GetMembershipsById(membershipId, membershipType));
        }

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
        [HttpGet("GetMembershipFromHardLinkedCredential/{crType}/{credential}")]
        public async Task<ActionResult<BasicResponse<HardLinkedUserMembership>>> GetMembershipFromHardLinkedCredential([FromRoute]BungieCredentialType crType, [FromRoute]string credential)
        {
            return Ok(await _helper.GetMembershipFromHardLinkedCredential(credential, crType));
        }

        /// <summary>
        /// Allow to search user by entering a prefix of the username
        /// </summary>
        /// <param name="displayNamePrefix">The display name prefix you're looking for.</param>
        /// <param name="page">The zero-based page of results you desire.</param>
        [HttpGet("Search/Prefix/{displayNamePrefix}/{page}")]
        [Obsolete("Do not use this to search users, use SearchByGlobalNamePost instead.")]
        public async Task<ActionResult<BasicResponse<UserSearchResponse>>> SearchByGlobalNamePrefix([FromRoute] string displayNamePrefix, [FromRoute] int page = 0)
        {
            return Ok(await _helper.SearchByGlobalNamePrefix(displayNamePrefix, page));
        }

        /// <summary>
        /// Given the prefix of a global display name, returns all users who share that name.
        /// </summary>
        /// <param name="content">Contain the data for the research query</param>
        /// <param name="page">The zero-based page of results you desire.</param>
        [HttpPost("Search/GlobalName/{page}")]
        public async Task<ActionResult<BasicResponse<UserSearchResponse>>> SearchByGlobalNamePost([FromBody] UserSearchPrefixRequest content, [FromRoute] int page = 0)
        {
            return Ok(await _helper.SearchByGlobalNamePost(content, page));
        }
    }
}
