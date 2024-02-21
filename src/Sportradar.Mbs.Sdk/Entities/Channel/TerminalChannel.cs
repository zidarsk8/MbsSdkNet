using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

/// <summary>
/// Represents a terminal channel.
/// </summary>
public class TerminalChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "terminal";

    /// <summary>
    /// Gets or sets the terminal ID.
    /// </summary>
    [JsonPropertyName("terminalId")]
    public string? TerminalId { get; set; }

    /// <summary>
    /// Gets or sets the shop ID.
    /// </summary>
    [JsonPropertyName("shopId")]
    public string? ShopId { get; set; }

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}