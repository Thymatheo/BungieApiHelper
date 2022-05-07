using BungieApiHelper.Entity.Ignores;

namespace BungieApiHelper.Entity.Tags.Models.Contracts {
    public class TagResponse {
        public string tagText { get; set; }
        public IgnoreResponse ignoreStatus { get; set; }
    }
}
