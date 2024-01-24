using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Request;

namespace Sportradar.Mbs.Sdk.Entities.Internal;

public class Request
{
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    [JsonPropertyName("timestampUtc")]
    public long TimestampUtc { get; set; }

    [JsonPropertyName("operatorId")]
    public long OperatorId { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("content")]
    public ContentRequestBase? Content { get; set; }
}