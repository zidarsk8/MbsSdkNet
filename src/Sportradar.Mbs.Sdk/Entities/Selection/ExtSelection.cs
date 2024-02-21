using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

/// <summary>
/// Represents an external selection.
/// </summary>
public class ExtSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "external";

    /// <summary>
    /// Gets or sets the expected settlement time of the selection.
    /// </summary>
    [JsonPropertyName("expSettleTime")]
    public long ExpSettleTime { get; set; }

    /// <summary>
    /// Gets or sets the odds of the selection.
    /// </summary>
    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }

    /// <summary>
    /// Gets or sets the event associated with the selection.
    /// </summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>
    /// Gets or sets the outcome identifier of the selection.
    /// </summary>
    [JsonPropertyName("outcome")]
    public string? Outcome { get; set; }
}