using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Odds;

namespace Com.Sportradar.Mbs.Sdk.Entities.Selection;

public class OddsBoostSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "odds-boost";

    [JsonPropertyName("selection")]
    public SelectionBase? Selection { get; set; }

    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }
}