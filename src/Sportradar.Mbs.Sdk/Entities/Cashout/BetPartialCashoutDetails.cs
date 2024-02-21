using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Cashout;

/// <summary>
/// Represents the details of a partial cashout for a bet.
/// </summary>
public class BetPartialCashoutDetails : CashoutDetailsBase
{
    /// <summary>
    /// Gets the type of the cashout details.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bet-partial";

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the percentage.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("percentage")]
    public decimal? Percentage { get; set; }

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