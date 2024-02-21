using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Response;

namespace Sportradar.Mbs.Sdk.Entities.Internal;

/// <summary>
/// Represents a response from the server.
/// </summary>
public class Response
{
    /// <summary>
    /// Gets or sets the correlation ID.
    /// </summary>
    [JsonPropertyName("correlationId")]
    public string? CorrelationId { get; set; }

    /// <summary>
    /// Gets or sets the UTC millis timestamp.
    /// </summary>
    [JsonPropertyName("timestampUtc")]
    public long TimestampUtc { get; set; }

    /// <summary>
    /// Gets or sets the operation.
    /// </summary>
    [JsonPropertyName("operation")]
    public string? Operation { get; set; }

    /// <summary>
    /// Gets or sets the version.
    /// </summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>
    /// Gets or sets the content.
    /// </summary>
    [JsonPropertyName("content")]
    public ContentResponseBase? Content { get; set; }
}