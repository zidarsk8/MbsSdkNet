using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Request;

public class WithdrawalInformRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "withdrawal-inform";

    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    [JsonPropertyName("withdrawalId")]
    public string? WithdrawalId { get; set; }

    [JsonPropertyName("amount")]
    public Amount? Amount { get; set; }

    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }

    [JsonPropertyName("executedAtUtc")]
    public long ExecutedAtUtc { get; set; }

    [JsonPropertyName("initiatedAtUtc")]
    public long InitiatedAtUtc { get; set; }

    [JsonPropertyName("gateway")]
    public PaymentGateway? Gateway { get; set; }

    [JsonPropertyName("status")]
    public BalanceMoveStatus? Status { get; set; }
}