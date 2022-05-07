using BungieApiHelper.Entity;
using BungieApiHelper.Entity.User;
using BungieApiHelper.Entity.User.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper.Auth {
    public class UserAuthHelper : BasicAuthHelper {
        public UserAuthHelper() : base("User") { }

        /// <summary>
        /// Returns a list of credential types attached to the requested account
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadBasicUserProfile
        /// </remarks>
        /// <param name="id">The user's membership id</param>
        public async Task<BasicResponse<IEnumerable<CredentialTypesForAccountResponse>>> GetCredentialTypesForTargetAccount(int id) =>
            await Get<IEnumerable<CredentialTypesForAccountResponse>>($"GetCredentialTypesForTargetAccount/{id}");

        /// <summary>
        /// Returns a list of accounts associated with signed in user.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : ReadBasicUserProfile
        /// </remarks>
        /// <remarks>This is useful for OAuth implementations that do not give you access to the token response.</remarks>
        public async Task<BasicResponse<UserMemberShipData>> GetMembershipsForCurrentUser() =>
            await Get<UserMemberShipData>("GetMembershipsForCurrentUser");
    }
}
