using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Stake;

namespace Sportradar.Mbs.Sdk.Entities.Suggestion;

/// <summary>
/// Represents a reoffer suggestion.
/// </summary>
public class ReofferSuggestion : SuggestionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "reoffer";

    /// <summary>
    /// Gets or sets the mode of the reoffer suggestion.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Gets or sets the stake of the reoffer suggestion.
    /// </summary>
    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }
}