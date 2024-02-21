using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;

namespace Sportradar.Mbs.Sdk.Entities.Cashout;

/// <summary>
/// Represents the details of a cashout for a ticket.
/// </summary>
public class TicketCashoutDetails : CashoutDetailsBase
{
    /// <summary>
    /// Represents the details of a cashout ticket.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    /// <summary>
    /// Gets or sets the code associated with the cashout ticket.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the payout details of the cashout.
    /// </summary>
    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    /// <summary>
    /// Gets or sets the signature of the ticket associated with the cashout.
    /// </summary>
    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket associated with the cashout.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}