using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a request to acknowledge an external settlement.
/// </summary>
public class ExtSettlementAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ext-settlement-ack";

    /// <summary>
    /// Gets or sets a value indicating whether the settlement is acknowledged.
    /// </summary>
    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    /// <summary>
    /// Gets or sets the settlement signature.
    /// </summary>
    [JsonPropertyName("settlementSignature")]
    public string? SettlementSignature { get; set; }

    /// <summary>
    /// Gets or sets the settlement ID.
    /// </summary>
    [JsonPropertyName("settlementId")]
    public string? SettlementId { get; set; }

    /// <summary>
    /// Gets or sets the ticket ID.
    /// </summary>
    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}