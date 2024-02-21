using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;

namespace Sportradar.Mbs.Sdk.Entities.Settlement;

/// <summary>
/// Represents the external settlement details for a ticket.
/// </summary>
public class TicketExtSettlementDetails : ExtSettlementDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    /// <summary>
    /// Gets or sets the payout details for the ticket.
    /// </summary>
    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    /// <summary>
    /// Gets or sets the signature of the ticket.
    /// </summary>
    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}