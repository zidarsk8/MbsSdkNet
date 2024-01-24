using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

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