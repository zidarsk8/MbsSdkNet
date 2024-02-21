using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

/// <summary>
/// Represents an agent channel.
/// </summary>
public class AgentChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "agent";

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}