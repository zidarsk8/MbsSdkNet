using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Channel;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

public class CasinoContext
{
    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    [JsonPropertyName("channel")]
    public ChannelBase? Channel { get; set; }

    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }
}