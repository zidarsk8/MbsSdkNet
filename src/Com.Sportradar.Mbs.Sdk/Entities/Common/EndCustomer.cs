using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

public class EndCustomer
{
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("confidence")]
    public decimal? Confidence { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}