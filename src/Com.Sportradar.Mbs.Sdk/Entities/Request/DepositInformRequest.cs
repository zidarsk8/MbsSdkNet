using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Common;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class DepositInformRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "deposit-inform";

    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    [JsonPropertyName("depositId")]
    public string? DepositId { get; set; }

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