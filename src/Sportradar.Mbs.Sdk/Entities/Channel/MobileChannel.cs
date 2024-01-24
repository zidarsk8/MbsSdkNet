using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

public class MobileChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "mobile";

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }
}