using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

public class SmsChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "sms";

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }
}