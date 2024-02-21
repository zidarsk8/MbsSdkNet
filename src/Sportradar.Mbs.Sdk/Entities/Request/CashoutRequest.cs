using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Cashout;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a cashout request.
/// </summary>
public class CashoutRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cashout";

    /// <summary>
    /// Gets or sets the cashout ID.
    /// </summary>
    [JsonPropertyName("cashoutId")]
    public string? CashoutId { get; set; }

    /// <summary>
    /// Gets or sets the cashout details.
    /// </summary>
    [JsonPropertyName("details")]
    public CashoutDetailsBase? Details { get; set; }
}