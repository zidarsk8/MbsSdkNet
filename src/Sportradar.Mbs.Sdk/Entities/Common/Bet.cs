using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Selection;
using Sportradar.Mbs.Sdk.Entities.Stake;

namespace Sportradar.Mbs.Sdk.Entities.Common;

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