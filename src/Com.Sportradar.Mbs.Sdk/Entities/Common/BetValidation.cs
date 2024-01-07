using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

public class BetValidation
{
    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}