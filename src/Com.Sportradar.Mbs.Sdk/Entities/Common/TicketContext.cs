using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Channel;
using Com.Sportradar.Mbs.Sdk.Entities.Payout;
using Com.Sportradar.Mbs.Sdk.Entities.Ref;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

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