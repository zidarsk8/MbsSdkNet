using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

/// <summary>
/// Represents a mobile channel.
/// </summary>
public class MobileChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "mobile";

    /// <summary>
    /// Gets or sets the IP address.
    /// </summary>
    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [JsonPropertyName("lang")]
    public string? Lang { get; set; }

    /// <summary>
    /// Gets or sets the device ID.
    /// </summary>
    [JsonPropertyName("deviceId")]
    public string? DeviceId { get; set; }
}