using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

/// <summary>
/// Represents the details of a partial cancellation of a bet.
/// </summary>
public class BetPartialCancelDetails : CancelDetailsBase
{
    /// <summary>
    /// Represents the type of cancellation, which is "bet-partial".
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bet-partial";

    /// <summary>
    /// Gets or sets the cancellation code.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the percentage of the bet that is being cancelled.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("percentage")]
    public decimal? Percentage { get; set; }

    /// <summary>
    /// Gets or sets the ID of the bet being cancelled.
    /// </summary>
    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    /// <summary>
    /// Gets or sets the signature of the ticket being cancelled.
    /// </summary>
    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket being cancelled.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}