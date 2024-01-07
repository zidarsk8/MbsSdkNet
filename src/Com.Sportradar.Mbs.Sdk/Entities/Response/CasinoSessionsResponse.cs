using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Response;

public class CasinoSessionsResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "casino-sessions-inform-reply";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}