using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Response;

namespace Sportradar.Mbs.Sdk.Entities.Internal;

public class Response
{
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    [JsonPropertyName("timestampUtc")]
    public long TimestampUtc { get; set; }

    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }

    [JsonPropertyName("content")]
    public ContentResponseBase? Content { get; set; }
}