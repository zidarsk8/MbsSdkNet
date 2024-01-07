using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Odds;

namespace Com.Sportradar.Mbs.Sdk.Entities.Selection;

public class ExtSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "external";

    [JsonPropertyName("expSettleTime")]
    public long ExpSettleTime { get; set; }

    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }

    [JsonPropertyName("event")]
    public string? Event { get; set; }

    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }
}