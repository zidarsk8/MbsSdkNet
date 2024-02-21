using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

/// <summary>
/// Represents an internet channel.
/// </summary>
public class InternetChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "internet";

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