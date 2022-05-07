using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.GroupsV2 {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DefaultPublicityEnum {
        Public = 0,
        Alliance = 1,
        Private = 2
    }
}