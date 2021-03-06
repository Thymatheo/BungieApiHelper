using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.GroupsV2 {
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum JoinLevelEnum {
        None = 0,
        Beginner = 1,
        Member = 2,
        Admin = 3,
        ActingFounder = 4,
        Founder = 5,
    }
}