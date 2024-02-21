using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Suggestion;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents the details of a bet.
/// </summary>
public class BetDetail
{
    /// <summary>
    /// Gets or sets the code associated with the bet.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the suggestion base associated with the bet.
    /// </summary>
    [JsonPropertyName("suggestion")]
    public SuggestionBase? Suggestion { get; set; }

    /// <summary>
    /// Gets or sets the bet ID associated with the bet.
    /// </summary>
    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    /// <summary>
    /// Gets or sets the selection details associated with the bet.
    /// </summary>
    [JsonPropertyName("selectionDetails")]
    public SelectionDetail[]? SelectionDetails { get; set; }

    /// <summary>
    /// Gets or sets the message associated with the bet.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}