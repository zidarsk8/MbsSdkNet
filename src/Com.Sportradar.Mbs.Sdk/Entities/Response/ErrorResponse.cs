using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Response;

public class ErrorResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "error-reply";

    [JsonPropertyName("message")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("code")]
    public int ErrorCode { get; set; }
}
