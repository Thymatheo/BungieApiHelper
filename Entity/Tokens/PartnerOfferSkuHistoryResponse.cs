using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Tokens {
    public class PartnerOfferSkuHistoryResponse {
        public string SkuIdentifier { get; set; }
        public string LocalizedName { get; set; }
        public string LocalizedDescription { get; set; }
        public DateTime ClaimDate { get; set; }
        public bool AllOffersApplied { get; set; }
        public string TransactionId { get; set; }
        public IEnumerable<PartnerOfferHistoryResponse> SkuOffers { get; set; }
    }
}
