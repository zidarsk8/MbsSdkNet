using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

public class AccumulatorSelection : SelectionBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "accumulator";

    [JsonPropertyName("selections")]
    public SelectionBase[]? Selections { get; set; }
}