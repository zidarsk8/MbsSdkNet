using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Suggestion;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

public class BetDetail
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("suggestion")]
    public SuggestionBase? Suggestion { get; set; }

    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    [JsonPropertyName("selectionDetails")]
    public SelectionDetail[]? SelectionDetails { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}