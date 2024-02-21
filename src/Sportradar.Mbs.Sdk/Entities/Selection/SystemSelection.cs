using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

/// <summary>
/// Represents a system selection.
/// </summary>
public class SystemSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "system";

    /// <summary>
    /// Gets or sets the array of selections of the system.
    /// </summary>
    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }

    /// <summary>
    /// Gets or sets the array of system sizes.
    /// </summary>
    [JsonPropertyName("size")]
    public int[]? Size { get; set; }
}