using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Channel;

public class RetailChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "retail";

    [JsonPropertyName("shopId")]
    public string? ShopId { get; set; }

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }
}