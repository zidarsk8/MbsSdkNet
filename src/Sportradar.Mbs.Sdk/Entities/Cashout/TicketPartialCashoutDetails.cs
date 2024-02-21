using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Cashout;

/// <summary>
/// Represents the details of a partial cashout for a ticket.
/// </summary>
public class TicketPartialCashoutDetails : CashoutDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-partial";

    /// <summary>
    /// Gets or sets the code associated with the partial cashout ticket.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the percentage of the partial cashout.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("percentage")]
    public decimal? Percentage { get; set; }

    /// <summary>
    /// Gets or sets the payout details of the partial cashout.
    /// </summary>
    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    /// <summary>
    /// Gets or sets the signature of the ticket associated with the partial cashout.
    /// </summary>
    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket associated with the partial cashout.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}