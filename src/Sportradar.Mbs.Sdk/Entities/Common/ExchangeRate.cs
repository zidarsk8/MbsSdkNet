using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents an exchange rate between two currencies (source currency amount * rate = target currency amount).
/// </summary>
public class ExchangeRate
{
    /// <summary>
    /// Gets or sets the currency code of the target currency.
    /// </summary>
    [JsonPropertyName("toCurrency")]
    public string? ToCurrency { get; set; }

    /// <summary>
    /// Gets or sets the exchange rate value.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("rate")]
    public decimal? Rate { get; set; }

    /// <summary>
    /// Gets or sets the currency code of the source currency.
    /// </summary>
    [JsonPropertyName("fromCurrency")]
    public string? FromCurrency { get; set; }
}