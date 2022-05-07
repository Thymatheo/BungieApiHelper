using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.GroupsV2 {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MembershipOptionEnum {
        Reviewed = 0,
        Open = 1,
        Closed = 2,
    }
}