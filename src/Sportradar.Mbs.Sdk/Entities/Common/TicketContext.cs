using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Channel;
using Sportradar.Mbs.Sdk.Entities.Payout;
using Sportradar.Mbs.Sdk.Entities.Ref;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents the context of a ticket.
/// </summary>
public class TicketContext
{
    /// <summary>
    /// Gets or sets the wallet ID.
    /// </summary>
    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    /// <summary>
    /// Gets or sets the reference to the previous ticket.
    /// </summary>
    [JsonPropertyName("ref")]
    public TicketRefBase? Ref { get; set; }

    /// <summary>
    /// Gets or sets the channel.
    /// </summary>
    [JsonPropertyName("channel")]
    public ChannelBase? Channel { get; set; }

    /// <summary>
    /// Gets or sets the limit ID.
    /// </summary>
    [JsonPropertyName("limitId")]
    public long LimitId { get; set; }

    /// <summary>
    /// Gets or sets the payout cap.
    /// </summary>
    [JsonPropertyName("payoutCap")]
    public PayoutBase[]? PayoutCap { get; set; }

    /// <summary>
    /// Gets or sets the end customer.
    /// </summary>
    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }
}