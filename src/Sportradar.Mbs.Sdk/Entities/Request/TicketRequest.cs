using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a ticket request.
/// </summary>
public class TicketRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    /// <summary>
    /// Gets or sets the context of the ticket.
    /// </summary>
    [JsonPropertyName("context")]
    public TicketContext? Context { get; set; }

    /// <summary>
    /// Gets or sets the array of bets in the ticket.
    /// </summary>
    [JsonPropertyName("bets")]
    public Bet[]? Bets { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}