using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a request to acknowledge a ticket.
/// </summary>
public class TicketAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-ack";

    /// <summary>
    /// Gets or sets a value indicating whether the ticket has been acknowledged.
    /// </summary>
    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

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