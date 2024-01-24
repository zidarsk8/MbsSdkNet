using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Cashout;

public class TicketPartialCashoutDetails : CashoutDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-partial";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("percentage")]
    public decimal? Percentage { get; set; }

    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}