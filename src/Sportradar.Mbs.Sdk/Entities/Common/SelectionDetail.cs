using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Odds;
using Sportradar.Mbs.Sdk.Entities.Selection;

namespace Sportradar.Mbs.Sdk.Entities.Common;

/// <summary>
/// Represents a detailed information about a selection.
/// </summary>
public class SelectionDetail
{
    /// <summary>
    /// Gets or sets the selection code.
    /// </summary>
    [JsonPropertyName("code")]
    public int Code { get; set; }

    /// <summary>
    /// Gets or sets the selection base.
    /// </summary>
    [JsonPropertyName("selection")]
    public SelectionBase? Selection { get; set; }

    /// <summary>
    /// Gets or sets the selection message.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// Gets or sets the auto-accepted odds.
    /// </summary>
    [JsonPropertyName("autoAcceptedOdds")]
    public OddsBase? AutoAcceptedOdds { get; set; }
}