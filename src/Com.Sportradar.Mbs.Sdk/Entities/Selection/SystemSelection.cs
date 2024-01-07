using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Selection;

public class SystemSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "system";

    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }

    [JsonPropertyName("size")]
    public int[]? Size { get; set; }
}