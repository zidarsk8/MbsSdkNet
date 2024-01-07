using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Common;

namespace Com.Sportradar.Mbs.Sdk.Entities.Request;

public class TicketInformRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-inform";

    [JsonPropertyName("ticket")]
    public TicketRequest? Ticket { get; set; }

    [JsonPropertyName("betValidations")]
    public BetValidation[]? BetValidations { get; set; }
}