using BungieApiHelper.Entity;
using BungieApiHelper.Entity.User;
using BungieApiHelper.Entity.User.Models;
using BungieApiHelper.Helper.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller.Auth {
    [ApiExplorerSettings(IgnoreApi = false)]
    public class UserAuthController : BasicAuthController<UserAuthHelper> {

        /// <summary>
        /// Returns a list of credential types attached to the requested account
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadBasicUserProfile
        /// </remarks>
        /// <param name="id">The user's membership id</param>
        [HttpGet("GetCredentialTypesForTargetAccount/{id}")]
        public async Task<ActionResult<BasicResponse<IEnumerable<CredentialTypesForAccountResponse>>>> GetCredentialTypesForTargetAccount([FromRoute] int id) {
            return Ok(await _helper.GetCredentialTypesForTargetAccount(id));
        }

        /// <summary>
        /// Returns a list of accounts associated with signed in user.
        /// </summary>
        /// <remarks>
        /// This is useful for OAuth implementations that do not give you access to the token response.
        /// <para>
        /// Oauth Scope : ReadBasicUserProfile
        /// </para>
        /// </remarks>
        [HttpGet("GetMembershipsForCurrentUser")]
        public async Task<ActionResult<BasicResponse<UserMemberShipData>>> GetMembershipsForCurrentUser() {
            return Ok(await _helper.GetMembershipsForCurrentUser());
        }
    }
}
