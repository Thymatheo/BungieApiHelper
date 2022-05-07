using System.Collections.Generic;

namespace BungieApiHelper.Entity.Content.Models {
    public class TagMetadataItem {
        public string description { get; set; }
        public string? tagText { get; set; }
        public IEnumerable<string?> groups { get; set; }
        public bool isDefault { get; set; }
        public string? name { get; set; }
    }
}