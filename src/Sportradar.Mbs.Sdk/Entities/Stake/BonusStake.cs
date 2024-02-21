using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Stake;

/// <summary>
/// Represents a bonus stake.
/// </summary>
public class BonusStake : StakeBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bonus";

    /// <summary>
    /// Gets or sets the mode of the stake.
    /// </summary>
    [JsonPropertyName("mode")]
    public StakeMode? Mode { get; set; }

    /// <summary>
    /// Gets or sets the trace ID of the stake.
    /// </summary>
    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }

    /// <summary>
    /// Gets or sets the amount of the stake.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("amount")]
    public decimal? Amount { get; set; }

    /// <summary>
    /// Gets or sets the currency of the stake.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
}