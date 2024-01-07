using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Balancechangesource;

public class WithdrawalBalanceChangeSource : BalanceChangeSourceBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "withdrawal";

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}