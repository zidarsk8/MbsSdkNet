using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents the context of a bet.
/// </summary>
public class BetContext
{
    /// <summary>
    /// Gets or sets the odds change for the bet.
    /// </summary>
    [JsonPropertyName("oddsChange")]
    public OddsChange? OddsChange { get; set; }

    /// <summary>
    /// Gets or sets the payout cap for the bet.
    /// </summary>
    [JsonPropertyName("payoutCap")]
    public PayoutBase[]? PayoutCap { get; set; }
}