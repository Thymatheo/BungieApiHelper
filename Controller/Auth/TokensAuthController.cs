using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Tokens;
using BungieApiHelper.Helper.Auth;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BungieApiHelper.Controller.Auth {
    public class TokensAuthController : BasicAuthController<TokensAuthHelper> {
        /// <summary>
        /// Claim a partner offer as the authenticated user.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : PartnerOfferGrant
        /// </remarks>
        /// <param name="content"></param>
        [HttpPost("Partner/ClaimOffer")]
        public async Task<ActionResult<BasicResponse<bool>>> ClaimPartnerOffer([FromBody] PartnerOfferClaimRequest content) =>
            Ok(await _helper.ClaimPartnerOffer(content));

        /// <summary>
        /// Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : PartnerOfferGrant
        /// </remarks>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        public async Task<ActionResult<BasicResponse<bool>>> ApplyMissingPartnerOffersWithoutClaim([FromRoute] int partnerApplicationId, [FromRoute] int targetBnetMembershipId) =>
            Ok(await _helper.ApplyMissingPartnerOffersWithoutClaim(partnerApplicationId, targetBnetMembershipId));
    }
}
