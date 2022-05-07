using BungieApiHelper.Entity.Ignores;
using System;

namespace BungieApiHelper.Entity.Forum {
    public class PostResponse {
        public DateTime lastReplyTimestamp { get; set; }
        public bool IsPinned { get; set; }
        public int urlMediaType { get; set; }
        public string thumbnail { get; set; }
        public int popularity { get; set; }
        public bool isActive { get; set; }
        public bool isAnnouncement { get; set; }
        public bool userRating { get; set; }
        public bool userHasRated { get; set; }
        public bool userHasMutedPost { get; set; }
        public string latestReplyPostId { get; set; }
        public string latestReplyAuthorId { get; set; }
        public IgnoreResponse ignoreStatus { get; set; }
        public string locale { get; set; }
    }
}