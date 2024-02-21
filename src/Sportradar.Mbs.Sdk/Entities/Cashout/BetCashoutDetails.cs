using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;

namespace Sportradar.Mbs.Sdk.Entities.Cashout;

/// <summary>
/// Represents the details of a cashout for a bet.
/// </summary>
public class BetCashoutDetails : CashoutDetailsBase
{
    /// <summary>
    /// Represents the details of a bet cashout.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bet";

    /// <summary>
    /// Gets or sets the code associated with the bet cashout.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the ID of the bet associated with the cashout.
    /// </summary>
    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    /// <summary>
    /// Gets or sets the payout details for the cashout.
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