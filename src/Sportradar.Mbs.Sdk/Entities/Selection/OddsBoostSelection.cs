using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

/// <summary>
/// Represents an odds boost selection.
/// </summary>
public class OddsBoostSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "odds-boost";

    /// <summary>
    /// Gets or sets the selection for the odds boost.
    /// </summary>
    [JsonPropertyName("selection")]
    public SelectionBase? Selection { get; set; }

    /// <summary>
    /// Gets or sets the odds for the selection (boosted odds).
    /// </summary>
    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }
}