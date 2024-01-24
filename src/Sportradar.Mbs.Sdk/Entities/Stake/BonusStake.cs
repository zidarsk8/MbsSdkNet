using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Stake;

public class BonusStake : StakeBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bonus";

    [JsonPropertyName("mode")]
    public StakeMode? Mode { get; set; }

    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }

    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("amount")]
    public decimal? Amount { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
}