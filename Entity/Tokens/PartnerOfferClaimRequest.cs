using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.Tokens {
    public class PartnerOfferClaimRequest {
        public string PartnerOfferId { get; set; }
        public string BungieNetMembershipId { get; set; }
        public string TransactionId { get; set; }
    }
}
