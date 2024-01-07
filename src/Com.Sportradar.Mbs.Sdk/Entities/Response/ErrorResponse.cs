using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Response;

public class ErrorResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "error-reply";

    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }

    [JsonPropertyName("errorCode")]
    public int ErrorCode { get; set; }
}