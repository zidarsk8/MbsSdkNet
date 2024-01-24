using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;
using Sportradar.Mbs.Sdk.Entities.Selection;

namespace Sportradar.Mbs.Sdk.Entities.Common;

public class SelectionDetail
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("selection")]
    public SelectionBase? Selection { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("autoAcceptedOdds")]
    public OddsBase? AutoAcceptedOdds { get; set; }
}