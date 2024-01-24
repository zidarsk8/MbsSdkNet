using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Casinospin;

public class FreeCasinoSpin : CasinoSpinBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "free";

    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("winningCount")]
    public int WinningCount { get; set; }
}