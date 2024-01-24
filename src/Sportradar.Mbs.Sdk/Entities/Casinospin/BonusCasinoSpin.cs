using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Casinospin;

public class BonusCasinoSpin : CasinoSpinBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bonus";

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("winningCount")]
    public int WinningCount { get; set; }
}