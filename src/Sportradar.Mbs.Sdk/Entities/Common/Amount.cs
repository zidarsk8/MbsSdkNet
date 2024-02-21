using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents an monetary amount with a currency and quantity (value).
/// </summary>
public class Amount
{
    /// <summary>
    /// Gets or sets the currency of the amount.
    /// </summary>
    [JsonPropertyName("currency")]
    public string? Currency { get; set; }

    /// <summary>
    /// Gets or sets the quantity (value) of the amount.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("value")]
    public decimal? Value { get; set; }
}