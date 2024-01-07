using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;

namespace Com.Sportradar.Mbs.Sdk.Entities.Odds;

public class DecimalOdds : OddsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "decimal";

    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }
}