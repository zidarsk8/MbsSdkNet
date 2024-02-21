using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Balancechangesource;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a request to inform about a balance change.
/// </summary>
public class BalanceChangeInformRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "balance-change-inform";

    /// <summary>
    /// Gets or sets the wallet ID.
    /// </summary>
    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    /// <summary>
    /// Gets or sets the balance change ID.
    /// </summary>
    [JsonPropertyName("balanceChangeId")]
    public string? BalanceChangeId { get; set; }

    /// <summary>
    /// Gets or sets the amount of the balance change.
    /// </summary>
    [JsonPropertyName("amount")]
    public Amount? Amount { get; set; }

    /// <summary>
    /// Gets or sets the end customer associated with the balance change.
    /// </summary>
    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }

    /// <summary>
    /// Gets or sets the UTC millis timestamp when the balance change was executed.
    /// </summary>
    [JsonPropertyName("executedAtUtc")]
    public long ExecutedAtUtc { get; set; }

    /// <summary>
    /// Gets or sets the source of the balance change.
    /// </summary>
    [JsonPropertyName("source")]
    public BalanceChangeSourceBase? Source { get; set; }

    /// <summary>
    /// Gets or sets the status of the balance change.
    /// </summary>
    [JsonPropertyName("status")]
    public BalanceChangeStatus? Status { get; set; }
}