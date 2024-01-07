using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Common;

namespace Com.Sportradar.Mbs.Sdk.Entities.Response;

public class ExtSettlementAckResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ext-settlement-ack-reply";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    [JsonPropertyName("settlementId")]
    public string? SettlementId { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }

    [JsonPropertyName("status")]
    public AcceptanceStatus? Status { get; set; }
}