using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Casinospin;

/// <summary>
/// Represents an ordinary casino spin.
/// </summary>
public class OrdinaryCasinoSpin : CasinoSpinBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ordinary";

    /// <summary>
    /// Gets or sets the count of the casino spins.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// Gets or sets the count of the winning casino spins.
    /// </summary>
    [JsonPropertyName("winningCount")]
    public int WinningCount { get; set; }
}