using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Channel;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class CasinoContext
{
    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    [JsonPropertyName("channel")]
    public ChannelBase? Channel { get; set; }

    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }
}