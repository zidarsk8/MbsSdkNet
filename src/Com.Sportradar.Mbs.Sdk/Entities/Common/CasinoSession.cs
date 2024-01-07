using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Casinospin;
using Com.Sportradar.Mbs.Sdk.Entities.Payout;
using Com.Sportradar.Mbs.Sdk.Entities.Stake;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

public class CasinoSession
{
    [JsonPropertyName("stake")]
    public StakeBase[]? Stake { get; set; }

    [JsonPropertyName("game")]
    public CasinoGame? Game { get; set; }

    [JsonPropertyName("spins")]
    public CasinoSpinBase[]? Spins { get; set; }

    [JsonPropertyName("payout")]
    public PayoutBase[]? Payout { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("startUtc")]
    public long StartUtc { get; set; }

    [JsonPropertyName("endUtc")]
    public long EndUtc { get; set; }
}