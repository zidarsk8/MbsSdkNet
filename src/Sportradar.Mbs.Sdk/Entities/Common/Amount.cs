using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class Amount
{
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }
}