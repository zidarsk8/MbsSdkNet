using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a request to acknowledge the cancellation of a ticket.
/// </summary>
public class CancelAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cancel-ack";

    /// <summary>
    /// Gets or sets the cancellation signature.
    /// </summary>
    [JsonPropertyName("cancellationSignature")]
    public string? CancellationSignature { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the cancellation has been acknowledged.
    /// </summary>
    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    /// <summary>
    /// Gets or sets the cancellation ID.
    /// </summary>
    [JsonPropertyName("cancellationId")]
    public string? CancellationId { get; set; }

    /// <summary>
    /// Gets or sets the ticket ID.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}