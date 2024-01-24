using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Cashout;

namespace Sportradar.Mbs.Sdk.Entities.Request;

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