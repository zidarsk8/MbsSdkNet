using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Cancellation;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a cancel request.
/// </summary>
public class CancelRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cancel";

    /// <summary>
    /// Gets or sets the cancel details.
    /// </summary>
    [JsonPropertyName("details")]
    public CancelDetailsBase? Details { get; set; }

    /// <summary>
    /// Gets or sets the cancellation ID.
    /// </summary>
    [JsonPropertyName("cancellationId")]
    public string? CancellationId { get; set; }
}