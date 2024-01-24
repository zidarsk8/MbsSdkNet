using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Request;

public class CashoutAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cashout-ack";

    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    [JsonPropertyName("cashoutId")]
    public string? CashoutId { get; set; }

    [JsonPropertyName("cashoutSignature")]
    public string? CashoutSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}