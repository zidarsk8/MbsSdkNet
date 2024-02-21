using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

/// <summary>
/// Represents the details of a bet cancellation.
/// </summary>
public class BetCancelDetails : CancelDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bet";

    /// <summary>
    /// Gets or sets the code associated with the cancellation.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the ID of the bet being cancelled.
    /// </summary>
    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    /// <summary>
    /// Gets or sets the signature of the ticket associated with the bet cancellation.
    /// </summary>
    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket associated with the bet cancellation.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}