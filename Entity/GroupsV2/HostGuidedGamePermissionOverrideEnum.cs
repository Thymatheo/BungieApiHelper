using System.Text.Json.Serialization;

namespace BungieApiHelper
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum HostGuidedGamePermissionOverrideEnum
    {
        None = 0,
        Beginner = 1,
        Member = 2
    }
}