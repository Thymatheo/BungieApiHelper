using System.Text.Json.Serialization;

namespace BungieApiHelper.Entity.GroupsV2
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HomepageEnum
    {
        Wall = 0,
        Forum = 1,
        AllianceForum = 2
    }
}