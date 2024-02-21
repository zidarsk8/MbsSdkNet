using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Casinospin;
using Sportradar.Mbs.Sdk.Entities.Payout;
using Sportradar.Mbs.Sdk.Entities.Stake;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents a casino session.
/// </summary>
public class CasinoSession
{
    /// <summary>
    /// Gets or sets the stake information for the casino session.
    /// </summary>
    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }

    /// <summary>
    /// Gets or sets the casino game information for the casino session.
    /// </summary>
    [JsonPropertyName("game")]
    public CasinoGame? Game { get; set; }

    /// <summary>
    /// Gets or sets the spins information for the casino session.
    /// </summary>
    [JsonPropertyName("spins")]
    public CasinoSpinBase[]? Spins { get; set; }

    /// <summary>
    /// Gets or sets the payout information for the casino session.
    /// </summary>
    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    /// <summary>
    /// Gets or sets the ID of the casino session.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Gets or sets the start time of the casino session in UTC millis.
    /// </summary>
    [JsonPropertyName("startUtc")]
    public long StartUtc { get; set; }

    /// <summary>
    /// Gets or sets the end time of the casino session in UTC millis.
    /// </summary>
    [JsonPropertyName("endUtc")]
    public long EndUtc { get; set; }
}