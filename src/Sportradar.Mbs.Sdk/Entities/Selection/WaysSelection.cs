using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

/// <summary>
/// Represents a ways selection in the MbsSdkNet library.
/// </summary>
public class WaysSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ways";

    /// <summary>
    /// Gets or sets the array of selections.
    /// </summary>
    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }
}