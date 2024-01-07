using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Selection;
using Com.Sportradar.Mbs.Sdk.Entities.Stake;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

public class Bet
{
    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }

    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }

    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    [JsonPropertyName("context")]
    public BetContext? Context { get; set; }
}