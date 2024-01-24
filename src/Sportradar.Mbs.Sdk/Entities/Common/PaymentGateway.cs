using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class PaymentGateway
{
    [JsonPropertyName("method")]
    public PaymentMethod? Method { get; set; }

    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    [JsonPropertyName("executedAtUtc")]
    public long ExecutedAtUtc { get; set; }

    [JsonPropertyName("initiatedAtUtc")]
    public long InitiatedAtUtc { get; set; }

    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }
}