using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class TicketAckRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-ack";

    [JsonPropertyName("acknowledged")]
    public bool? Acknowledged { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}