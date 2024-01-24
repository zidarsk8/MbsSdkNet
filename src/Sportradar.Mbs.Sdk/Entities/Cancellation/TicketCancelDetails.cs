using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

public class TicketCancelDetails : CancelDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}