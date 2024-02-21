using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Balancechangesource;

/// <summary>
/// Represents a balance change source for deposit transactions.
/// </summary>
public class DepositBalanceChangeSource : BalanceChangeSourceBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "deposit";

    /// <summary>
    /// Gets or sets the ID of the deposit producing balance change.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}