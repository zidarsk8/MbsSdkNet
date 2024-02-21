using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Stake;

namespace Sportradar.Mbs.Sdk.Entities.Suggestion;

/// <summary>
/// Represents an alternative stake suggestion.
/// </summary>
public class AltStakeSuggestion : SuggestionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "alt-stake";

    /// <summary>
    /// Gets or sets the stake for the suggestion.
    /// </summary>
    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }
}