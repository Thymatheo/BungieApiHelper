using System.Collections.Generic;

namespace BungieApiHelper.Entity.Content.Models {
    public class TagMetadataDefinition {
        public string description { get; set; }
        public int order { get; set; }
        public IEnumerable<TagMetadataItem> items { get; set; }
        public string datatype { get; set; }
        public string name { get; set; }
        public bool isRequired { get; set; }
    }
}