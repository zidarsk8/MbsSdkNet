using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Payout;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

public class BetContext
{
    [JsonPropertyName("oddsChange")]
    public OddsChange? OddsChange { get; set; }

    [JsonPropertyName("payoutCap")]
    public PayoutBase[]? PayoutCap { get; set; }
}