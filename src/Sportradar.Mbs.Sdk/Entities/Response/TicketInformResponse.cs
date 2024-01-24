using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Response;

public class TicketInformResponse : ContentResponseBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-inform-reply";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonPropertyName("exchangeRate")]
    public ExchangeRate[]? ExchangeRate { get; set; }

    [JsonPropertyName("signature")]
    public string? Signature { get; set; }

    [JsonPropertyName("betDetails")]
    public BetDetail[]? BetDetails { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }

    [JsonPropertyName("status")]
    public AcceptanceStatus? Status { get; set; }
}