using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Odds;

namespace Com.Sportradar.Mbs.Sdk.Entities.Selection;

public class UfSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "uf";

    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }

    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }

    [JsonPropertyName("outcomeId")]
    public string? OutcomeId { get; set; }

    [JsonPropertyName("specifiers")]
    public string? Specifiers { get; set; }

    [JsonPropertyName("marketId")]
    public string? MarketId { get; set; }
}