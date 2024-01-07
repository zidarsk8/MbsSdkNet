using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;

namespace Com.Sportradar.Mbs.Sdk.Entities.Stake;

public class FreeStake : StakeBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "free";

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