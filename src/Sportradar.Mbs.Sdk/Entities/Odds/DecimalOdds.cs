using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Odds;

/// <summary>
/// Represents decimal odds.
/// </summary>
public class DecimalOdds : OddsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "decimal";

    /// <summary>
    /// Gets or sets the decimal value of the odds: eg "1.75".
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }
}