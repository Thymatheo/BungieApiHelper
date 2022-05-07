using System.Collections.Generic;

namespace BungieApiHelper.Entity.Forum {
    public class PollResponse {
        public int topicId { get; set; }
        public IEnumerable<PollResult> results { get; set; }
        public int totalVotes { get; set; }
    }
}