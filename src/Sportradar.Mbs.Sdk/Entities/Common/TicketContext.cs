using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Channel;
using Sportradar.Mbs.Sdk.Entities.Payout;
using Sportradar.Mbs.Sdk.Entities.Ref;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class TicketContext
{
    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    [JsonPropertyName("ref")]
    public TicketRefBase? Ref { get; set; }

    [JsonPropertyName("channel")]
    public ChannelBase? Channel { get; set; }

    [JsonPropertyName("limitId")]
    public long LimitId { get; set; }

    [JsonPropertyName("payoutCap")]
    public PayoutBase[]? PayoutCap { get; set; }

    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }
}