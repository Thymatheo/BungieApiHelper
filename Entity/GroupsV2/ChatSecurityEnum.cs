using System.Text.Json.Serialization;

namespace BungieApiHelper
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ChatSecurityEnum
    {
        Group = 0,
        Admins = 1
    }
}