using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

/// <summary>
/// Represents a custom bet selection.
/// </summary>
public class UfCustomBetSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "uf-custom-bet";

    /// <summary>
    /// Gets or sets the array of (correlated) selections.
    /// </summary>
    [JsonPropertyName("selections")]
    public UfSelection[]? Selections { get; set; }

    /// <summary>
    /// Gets or sets the odds for the custom bet.
    /// </summary>
    [JsonPropertyName("odds")]
    public OddsBase? Odds { get; set; }
}