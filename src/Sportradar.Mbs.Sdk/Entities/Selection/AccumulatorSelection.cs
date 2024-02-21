using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

/// <summary>
/// Represents an accumulator selection.
/// </summary>
public class AccumulatorSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "accumulator";

    /// <summary>
    /// Gets or sets the array of selection included in the accumulator.
    /// </summary>
    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }
}