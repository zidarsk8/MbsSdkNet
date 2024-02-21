using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;

namespace Sportradar.Mbs.Sdk.Entities.Settlement;

/// <summary>
/// Represents the external settlement details for a bet.
/// </summary>
public class BetExtSettlementDetails : ExtSettlementDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bet";

    /// <summary>
    /// Gets or sets the ID of the bet.
    /// </summary>
    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    /// <summary>
    /// Gets or sets the payout details for the bet.
    /// </summary>
    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    /// <summary>
    /// Gets or sets the signature of the ticket associated with the bet.
    /// </summary>
    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket associated with the bet.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}