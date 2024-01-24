using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class ExchangeRate
{
    [JsonPropertyName("toCurrency")]
    public string? ToCurrency { get; set; }

    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("rate")]
    public decimal? Rate { get; set; }

    [JsonPropertyName("fromCurrency")]
    public string? FromCurrency { get; set; }
}