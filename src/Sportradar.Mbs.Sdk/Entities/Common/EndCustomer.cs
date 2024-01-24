using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class EndCustomer
{
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("confidence")]
    public decimal? Confidence { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}