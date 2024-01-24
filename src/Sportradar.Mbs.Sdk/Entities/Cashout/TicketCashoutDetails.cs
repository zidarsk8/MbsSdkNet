using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;

namespace Sportradar.Mbs.Sdk.Entities.Cashout;

public class TicketCashoutDetails : CashoutDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}