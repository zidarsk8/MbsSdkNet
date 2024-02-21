using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Response;

/// <summary>
/// Represents a response containing ticket information.
/// </summary>
public class TicketResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-reply";

    /// <summary>
    /// Gets or sets the code of the ticket response.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the exchange rates associated with the ticket response.
    /// </summary>
    [JsonPropertyName("exchangeRate")]
    public ExchangeRate[]? ExchangeRate { get; set; }

    /// <summary>
    /// Gets or sets the signature of the ticket response.
    /// </summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    /// <summary>
    /// Gets or sets the bet details associated with the ticket response.
    /// </summary>
    [JsonPropertyName("betDetails")]
    public BetDetail[]? BetDetails { get; set; }

    /// <summary>
    /// Gets or sets the message of the ticket response.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the ticket ID of the ticket response.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }

    /// <summary>
    /// Gets or sets the acceptance status of the ticket response.
    /// </summary>
    [JsonPropertyName("status")]
    public AcceptanceStatus? Status { get; set; }
}