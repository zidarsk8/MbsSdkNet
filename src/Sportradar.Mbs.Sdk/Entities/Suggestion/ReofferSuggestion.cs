using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Stake;

namespace Sportradar.Mbs.Sdk.Entities.Suggestion;

public class ReofferSuggestion : SuggestionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "reoffer";

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }
}