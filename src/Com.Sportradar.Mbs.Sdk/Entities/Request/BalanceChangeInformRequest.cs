using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Balancechangesource;
using Com.Sportradar.Mbs.Sdk.Entities.Common;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class BalanceChangeInformRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "balance-change-inform";

    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    [JsonPropertyName("balanceChangeId")]
    public string? BalanceChangeId { get; set; }

    [JsonPropertyName("amount")]
    public Amount? Amount { get; set; }

    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }

    [JsonPropertyName("executedAtUtc")]
    public long ExecutedAtUtc { get; set; }

    [JsonPropertyName("source")]
    public BalanceChangeSourceBase? Source { get; set; }

    [JsonPropertyName("status")]
    public BalanceChangeStatus? Status { get; set; }
}