using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Selection;
using Sportradar.Mbs.Sdk.Entities.Stake;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents a bet.
/// </summary>
public class Bet
{
    /// <summary>
    /// Gets or sets the stake for the bet.
    /// </summary>
    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }

    /// <summary>
    /// Gets or sets the selections for the bet.
    /// </summary>
    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the bet.
    /// </summary>
    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    /// <summary>
    /// Gets or sets the context of the bet.
    /// </summary>
    [JsonPropertyName("context")]
    public BetContext? Context { get; set; }
}