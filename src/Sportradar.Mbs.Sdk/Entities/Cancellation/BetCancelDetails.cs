using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

public class BetCancelDetails : CancelDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "bet";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("betId")]
    public string? BetId { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}