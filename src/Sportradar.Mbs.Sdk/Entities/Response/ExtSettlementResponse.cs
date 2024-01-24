using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Response;

public class ExtSettlementResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ext-settlement-reply";

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