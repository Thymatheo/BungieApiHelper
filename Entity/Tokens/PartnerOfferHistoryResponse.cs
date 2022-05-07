using BungieApiHelper.Entity.Bungie;
using System;

namespace BungieApiHelper.Entity.Tokens {
    public class PartnerOfferHistoryResponse {
        public string PartnerOfferKey { get; set; }
        public string MembershipId { get; set; }
        public BungieMembershipType MembershipType { get; set; }
        public string LocalizedName { get; set; }
        public string LocalizedDescription { get; set; }
        public DateTime? ApplyDate { get; set; }
    }
}
