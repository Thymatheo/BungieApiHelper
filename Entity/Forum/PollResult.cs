using System;

namespace BungieApiHelper.Entity.Forum {
    public class PollResult {
        public string answerText { get; set; }
        public int answerSlot { get; set; }
        public DateTime lastVoteDate { get; set; }
        public int votes { get; set; }
        public bool requestingUserVoted { get; set; }
    }
}