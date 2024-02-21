using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

/// <summary>
/// Represents a selection for the Unified feed (UF) selection.
/// </summary>
public class UfSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "uf";

    /// <summary>
    /// Gets or sets the unique identifier of the event associated with the selection.
    /// </summary>
    [JsonPropertyName("eventId")]
    public string? EventId { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the product associated with the selection.
    /// </summary>
    [JsonPropertyName("productId")]
    public string? ProductId { get; set; }

    /// <summary>
    /// Gets or sets the odds of the selection.
    /// </summary>
    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the outcome associated with the selection.
    /// </summary>
    [JsonPropertyName("outcomeId")]
    public string? OutcomeId { get; set; }

    /// <summary>
    /// Gets or sets the specifiers of the selection (market specifiers).
    /// </summary>
    [JsonPropertyName("specifiers")]
    public string? Specifiers { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the market associated with the selection.
    /// </summary>
    [JsonPropertyName("marketId")]
    public string? MarketId { get; set; }
}