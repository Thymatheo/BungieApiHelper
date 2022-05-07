using BungieApiHelper.Entity.User;
using System;
using System.Collections.Generic;

namespace BungieApiHelper.Entity.Content {
    public class ContentItemPublicContract {
        public int contentId { get; set; }
        public string cType { get; set; }
        public string cmsPath { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime modifyDate { get; set; }
        public bool allowComments { get; set; }
        public bool hasAgeGate { get; set; }
        public int minimumAge { get; set; }
        public string ratingImagePath { get; set; }
        public GeneralUser author { get; set; }
        public bool autoEnglishPropertyFallback { get; set; }
        /// <summary>
        /// Firehose content is really a collection of metadata and "properties", which are the potentially-but-not-strictly localizable data that comprises the meat of whatever content is being shown. As Cole Porter would have crooned, "Anything Goes" with Firehose properties.They are most often strings, but they can theoretically be anything.They are JSON encoded, and could be JSON structures, simple strings, numbers etc... The Content Type of the item (cType) will describe the properties, and thus how they ought to be deserialized.
        /// </summary>
        public Dictionary<string, object> properties { get; set; }
        public IEnumerable<ContentRepresentation> representations { get; set; }
        public IEnumerable<string> tags { get; set; }
        public CommentSummary commentSummary { get; set; }
    }
}
