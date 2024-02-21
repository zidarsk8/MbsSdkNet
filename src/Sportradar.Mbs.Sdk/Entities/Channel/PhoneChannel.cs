using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

/// <summary>
/// Represents a phone channel.
/// </summary>
public class PhoneChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "phone";

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}