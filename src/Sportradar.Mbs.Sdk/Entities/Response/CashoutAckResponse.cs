using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Response;

/// <summary>
/// Represents a response object for a cashout acknowledgement.
/// </summary>
public class CashoutAckResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cashout-ack-reply";

    /// <summary>
    /// Gets or sets the code of the cashout acknowledgement response.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the signature of the cashout acknowledgement response.
    /// </summary>
    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    /// <summary>
    /// Gets or sets the cashout ID of the cashout acknowledgement response.
    /// </summary>
    [JsonPropertyName("cashoutId")]
    public string? CashoutId { get; set; }

    /// <summary>
    /// Gets or sets the message of the cashout acknowledgement response.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the ticket ID of the cashout acknowledgement response.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }

    /// <summary>
    /// Gets or sets the status of the cashout acknowledgement response.
    /// </summary>
    [JsonPropertyName("status")]
    public AcceptanceStatus? Status { get; set; }
}