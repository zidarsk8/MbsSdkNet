using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

public class PhoneChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "phone";

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}