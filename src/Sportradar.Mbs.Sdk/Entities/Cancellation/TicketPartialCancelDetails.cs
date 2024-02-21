using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

/// <summary>
/// Represents the details of a partial cancellation for a ticket.
/// </summary>
public class TicketPartialCancelDetails : CancelDetailsBase
{
    /// <summary>
    /// Gets the type of the cancellation details.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-partial";

    /// <summary>
    /// Gets or sets the cancellation code.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the cancellation percentage.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("percentage")]
    public decimal? Percentage { get; set; }

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