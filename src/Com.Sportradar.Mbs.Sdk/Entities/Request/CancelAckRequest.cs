using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class CancelAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "cancel-ack";

    [JsonPropertyName("cancellationSignature")]
    public string? CancellationSignature { get; set; }

    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    [JsonPropertyName("cancellationId")]
    public string? CancellationId { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}