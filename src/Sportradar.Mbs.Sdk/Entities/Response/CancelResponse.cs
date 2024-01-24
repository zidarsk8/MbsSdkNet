using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Response;

public class CancelResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cancel-reply";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    [JsonPropertyName("cancellationId")]
    public string? CancellationId { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }

    [JsonPropertyName("status")]
    public AcceptanceStatus? Status { get; set; }
}