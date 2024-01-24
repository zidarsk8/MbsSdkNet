using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

public class InternetChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "internet";

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }
}