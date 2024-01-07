using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Ref;

public class AltStakeTicketRef : TicketRefBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "alt-stake";

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}