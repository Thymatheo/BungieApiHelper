using BungieApiHelper.Entity;
using BungieApiHelper.Entity.Tokens;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BungieApiHelper.Helper.Auth {
    public class TokensAuthHelper : BasicAuthHelper {
        public TokensAuthHelper() : base("Tokens") {
        }
        /// <summary>
        /// Claim a partner offer as the authenticated user.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : PartnerOfferGrant
        /// </remarks>
        /// <param name="content"></param>
        public async Task<BasicResponse<bool>> ClaimPartnerOffer(PartnerOfferClaimRequest content) =>
            await Post<bool>("Partner/ClaimOffer", content);
        /// <summary>
        /// Apply a partner offer to the targeted user. This endpoint does not claim a new offer, but any already claimed offers will be applied to the game if not already.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : PartnerOfferGrant
        /// </remarks>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        public async Task<BasicResponse<bool>> ApplyMissingPartnerOffersWithoutClaim(int partnerApplicationId, int targetBnetMembershipId) =>
            await Post<bool>($"Partner/ApplyMissingOffers/{partnerApplicationId}/{targetBnetMembershipId}", null);
        /// <summary>
        /// Returns the partner sku and offer history of the targeted user. Elevated permissions are required to see users that are not yourself.
        /// </summary>
        /// <remarks>
        /// Oauth Scope : PartnerOfferGrant
        /// </remarks>
        /// <param name="partnerApplicationId">The partner application identifier.</param>
        /// <param name="targetBnetMembershipId">The bungie.net user to apply missing offers to. If not self, elevated permissions are required.</param>
        public async Task<BasicResponse<IEnumerable<PartnerOfferSkuHistoryResponse>>> GetPartnerOfferSkuHistory(int partnerApplicationId, int targetBnetMembershipId) =>
            await Get<IEnumerable<PartnerOfferSkuHistoryResponse>>($"Partner/History/{partnerApplicationId}/{targetBnetMembershipId}");
    }
}
