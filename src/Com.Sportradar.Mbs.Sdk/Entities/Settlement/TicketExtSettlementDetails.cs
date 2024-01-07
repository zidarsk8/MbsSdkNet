using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Payout;

namespace Com.Sportradar.Mbs.Sdk.Entities.Settlement;

public class TicketExtSettlementDetails : ExtSettlementDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}