using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Casinospin;

/// <summary>
/// Represents a free casino spin.
/// </summary>
public class FreeCasinoSpin : CasinoSpinBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "free";

    /// <summary>
    /// Gets or sets the count of free spins.
    /// </summary>
    [JsonPropertyName("count")]
    public int Count { get; set; }

    /// <summary>
    /// Gets or sets the count of winning free spins.
    /// </summary>
    [JsonPropertyName("winningCount")]
    public int WinningCount { get; set; }
}