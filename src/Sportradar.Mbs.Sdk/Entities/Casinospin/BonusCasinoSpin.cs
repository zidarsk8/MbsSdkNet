using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Casinospin;

/// <summary>
/// Represents a bonus casino spin.
/// </summary>
public class BonusCasinoSpin : CasinoSpinBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bonus";

    /// <summary>
    /// Gets or sets the count of the bonus casino spins.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// Gets or sets the count of the winning bonus casino spins.
    /// </summary>
    [JsonPropertyName("winningCount")]
    public int WinningCount { get; set; }
}