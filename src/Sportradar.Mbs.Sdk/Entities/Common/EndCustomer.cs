using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents an end customer.
/// </summary>
public class EndCustomer
{
    /// <summary>
    /// Gets or sets the confidence level of the end customer.
    /// </summary>
    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("confidence")]
    public decimal? Confidence { get; set; }

    /// <summary>
    /// Gets or sets the ID of the end customer.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}