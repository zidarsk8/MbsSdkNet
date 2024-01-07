using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Channel;

public class TvAppChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "tv-app";

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }
}