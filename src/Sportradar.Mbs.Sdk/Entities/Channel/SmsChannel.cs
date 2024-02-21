using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

/// <summary>
/// Represents an SMS channel used for communication.
/// </summary>
public class SmsChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "sms";

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