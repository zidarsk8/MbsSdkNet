using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Payout;

namespace Com.Sportradar.Mbs.Sdk.Entities.Cashout;

public class BetCashoutDetails : CashoutDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bet";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}