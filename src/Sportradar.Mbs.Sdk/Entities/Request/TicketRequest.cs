using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Request;

public class TicketRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    [JsonPropertyName("context")]
    public TicketContext? Context { get; set; }

    [JsonPropertyName("bets")]
    public Bet[]? Bets { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}