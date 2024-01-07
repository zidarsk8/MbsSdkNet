using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Casinospin;

public class OrdinaryCasinoSpin : CasinoSpinBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ordinary";

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("winningCount")]
    public int WinningCount { get; set; }
}