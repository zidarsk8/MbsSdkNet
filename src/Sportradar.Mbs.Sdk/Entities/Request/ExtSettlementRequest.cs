using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Settlement;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents an external settlement request.
/// </summary>
public class ExtSettlementRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ext-settlement";

    /// <summary>
    /// Gets or sets the details of the external settlement request.
    /// </summary>
    [JsonPropertyName("details")]
    public ExtSettlementDetailsBase? Details { get; set; }

    /// <summary>
    /// Gets or sets the settlement ID of the external settlement request.
    /// </summary>
    [JsonPropertyName("settlementId")]
    public string? SettlementId { get; set; }
}