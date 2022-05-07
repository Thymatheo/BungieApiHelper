using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.GroupsV2 {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HostGuidedGamePermissionOverrideEnum {
        None = 0,
        Beginner = 1,
        Member = 2
    }
}