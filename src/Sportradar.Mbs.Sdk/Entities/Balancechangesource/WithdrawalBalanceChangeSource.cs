using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Balancechangesource;

/// <summary>
/// Represents a withdrawal balance change source.
/// </summary>
public class WithdrawalBalanceChangeSource : BalanceChangeSourceBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "withdrawal";

    /// <summary>
    /// Gets or sets the ID of the withdrawal producing balance change.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}