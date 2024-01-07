using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Cashout;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class CashoutRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cashout";

    [JsonPropertyName("cashoutId")]
    public string? CashoutId { get; set; }

    [JsonPropertyName("details")]
    public CashoutDetailsBase? Details { get; set; }
}