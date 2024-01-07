using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Cancellation;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class CancelRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cancel";

    [JsonPropertyName("details")]
    public CancelDetailsBase? Details { get; set; }

    [JsonPropertyName("cancellationId")]
    public string? CancellationId { get; set; }
}