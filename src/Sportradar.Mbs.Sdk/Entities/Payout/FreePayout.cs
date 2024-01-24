using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Payout;

public class FreePayout : PayoutBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "free";

    [JsonPropertyName("traceId")]
    public string? TraceId { get; set; }

    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("amount")]
    public decimal? Amount { get; set; }

    [JsonPropertyName("currency")]
    public string? Currency { get; set; }
}