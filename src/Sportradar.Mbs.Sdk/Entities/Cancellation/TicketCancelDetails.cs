using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

/// <summary>
/// Represents the details of a ticket cancellation.
/// </summary>
public class TicketCancelDetails : CancelDetailsBase
{
    /// <summary>
    /// Gets the type of the cancellation details.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    /// <summary>
    /// Gets or sets the code associated with the cancellation.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

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