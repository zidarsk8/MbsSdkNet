using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Settlement;

namespace Sportradar.Mbs.Sdk.Entities.Request;

public class ExtSettlementRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ext-settlement";

    [JsonPropertyName("details")]
    public ExtSettlementDetailsBase? Details { get; set; }

    [JsonPropertyName("settlementId")]
    public string? SettlementId { get; set; }
}