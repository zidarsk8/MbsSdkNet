using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a request to retrieve casino sessions information.
/// </summary>
public class CasinoSessionsRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "casino-sessions-inform";

    /// <summary>
    /// Gets or sets the casino sessions.
    /// </summary>
    [JsonPropertyName("sessions")]
    public CasinoSession[]? Sessions { get; set; }

    /// <summary>
    /// Gets or sets the report ID.
    /// </summary>
    [JsonPropertyName("reportId")]
    public string? ReportId { get; set; }

    /// <summary>
    /// Gets or sets the casino context.
    /// </summary>
    [JsonPropertyName("context")]
    public CasinoContext? Context { get; set; }
}