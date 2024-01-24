using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Payout;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class BetContext
{
    [JsonPropertyName("oddsChange")]
    public OddsChange? OddsChange { get; set; }

    [JsonPropertyName("payoutCap")]
    public PayoutBase[]? PayoutCap { get; set; }
}