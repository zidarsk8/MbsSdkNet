using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Ref;

public class ReofferTicketRef : TicketRefBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "reoffer";

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}