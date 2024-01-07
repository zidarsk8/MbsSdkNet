using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Common;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class CasinoSessionsRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "casino-sessions-inform";

    [JsonPropertyName("sessions")]
    public CasinoSession[]? Sessions { get; set; }

    [JsonPropertyName("reportId")]
    public string? ReportId { get; set; }

    [JsonPropertyName("context")]
    public CasinoContext? Context { get; set; }
}