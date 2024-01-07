using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;

namespace Com.Sportradar.Mbs.Sdk.Entities.Stake;

public class FreeCashStake : StakeBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "free-cash";

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