using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

/// <summary>
/// Represents the details of a reoffer cancellation.
/// </summary>
public class ReofferCancelDetails : CancelDetailsBase
{
    /// <summary>
    /// Gets the type of the cancellation details.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "reoffer";

    /// <summary>
    /// Gets or sets the cancellation code.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the ticket signature of ticket being cancelled.
    /// </summary>
    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    /// <summary>
    /// Gets or sets the ticket ID of ticket being cancelled.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}