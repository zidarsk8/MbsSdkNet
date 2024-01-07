using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Stake;

namespace Com.Sportradar.Mbs.Sdk.Entities.Suggestion;

public class AltStakeSuggestion : SuggestionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "alt-stake";

    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }
}