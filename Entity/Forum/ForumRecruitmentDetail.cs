using BungieApiHelper.Entity.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace BungieApiHelper.Entity.Forum
{
    public class ForumRecruitmentDetail
    {
        public int topicId { get; set; }
        public bool microphoneRequired { get; set; }
        public byte intensity { get; set; }
        public byte tone { get; set; }
        public bool approved { get; set; }
        public int? conversationId { get; set; }
        public int playerSlotsTotal { get; set; }
        public int playerSlotsRemaining { get; set; }
        public IEnumerable<GeneralUser> Fireteam { get; set; }
        public IEnumerable<int> kickedPlayerIds { get; set; }
    }
}
