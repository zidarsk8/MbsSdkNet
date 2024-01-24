using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

public class TerminalChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "terminal";

    [JsonPropertyName("terminalId")]
    public string? TerminalId { get; set; }

    [JsonPropertyName("shopId")]
    public string? ShopId { get; set; }

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}