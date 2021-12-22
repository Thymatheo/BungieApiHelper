using BungieApiHelper.Entity;
using BungieApiHelper.Entity.User;
using BungieApiHelper.Entity.User.Models;
using BungieApiHelper.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller.Auth
{
    public class UserAuthController :BasicAuthController<UserHelper>
    {

        /// <summary>
        /// Returns a list of credential types attached to the requested account
        /// </summary>
        /// <param name="id">The user's membership id</param>
        [HttpGet("GetCredentialTypesForTargetAccount/{id}")]
        public async Task<ActionResult<BasicResponse<IEnumerable<CredentialTypesForAccountResponse>>>> GetCredentialTypesForTargetAccount([FromRoute] int id)
        {
            return Ok(await _helper.GetCredentialTypesForTargetAccount(GetToken(), id));
        }

        /// <summary>
        /// Returns a list of accounts associated with signed in user.
        /// </summary>
        /// <remarks>This is useful for OAuth implementations that do not give you access to the token response.</remarks>
        [HttpGet("GetMembershipsForCurrentUser")]
        public async Task<ActionResult<BasicResponse<UserMemberShipData>>> GetMembershipsForCurrentUser()
        {
            return Ok(await _helper.GetMembershipsForCurrentUser(GetToken()));
        }
    }
}
