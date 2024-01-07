using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class ExtSettlementAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ext-settlement-ack";

    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    [JsonPropertyName("settlementSignature")]
    public string? SettlementSignature { get; set; }

    [JsonPropertyName("settlementId")]
    public string? SettlementId { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}