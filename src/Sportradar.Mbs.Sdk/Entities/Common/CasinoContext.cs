using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Channel;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents the context of a casino.
/// </summary>
public class CasinoContext
{
    /// <summary>
    /// Gets or sets the wallet ID.
    /// </summary>
    [JsonPropertyName("walletId")]
    public string? WalletId { get; set; }

    /// <summary>
    /// Gets or sets the channel.
    /// </summary>
    [JsonPropertyName("channel")]
    public ChannelBase? Channel { get; set; }

    /// <summary>
    /// Gets or sets the end customer.
    /// </summary>
    [JsonPropertyName("endCustomer")]
    public EndCustomer? EndCustomer { get; set; }
}