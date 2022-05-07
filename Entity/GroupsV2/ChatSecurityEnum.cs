using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.GroupsV2 {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ChatSecurityEnum {
        Group = 0,
        Admins = 1
    }
}