using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Stake;

namespace Sportradar.Mbs.Sdk.Entities.Suggestion;

public class AltStakeSuggestion : SuggestionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "alt-stake";

    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }
}