using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a request to acknowledge a cashout.
/// </summary>
public class CashoutAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cashout-ack";

    /// <summary>
    /// Gets or sets a value indicating whether the cashout has been acknowledged.
    /// </summary>
    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    /// <summary>
    /// Gets or sets the cashout ID.
    /// </summary>
    [JsonPropertyName("cashoutId")]
    public string? CashoutId { get; set; }

    /// <summary>
    /// Gets or sets the cashout signature.
    /// </summary>
    [JsonPropertyName("cashoutSignature")]
    public string? CashoutSignature { get; set; }

    /// <summary>
    /// Gets or sets the ticket ID.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}