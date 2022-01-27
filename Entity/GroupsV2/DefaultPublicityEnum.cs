using System.Text.Json.Serialization;

namespace BungieApiHelper
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DefaultPublicityEnum
    {
        Public = 0,
        Alliance = 1,
        Private = 2
    }
}