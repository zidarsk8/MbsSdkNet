using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Internal.Utils;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

public class TicketPartialCancelDetails : CancelDetailsBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-partial";

    [JsonPropertyName("code")]
    public int Code { get; set; }

    [JsonConverter(typeof(DecimalJsonConverter))]
    [JsonPropertyName("percentage")]
    public decimal? Percentage { get; set; }

    [JsonPropertyName("ticketSignature")]
    public string? TicketSignature { get; set; }

    [JsonPropertyName("ticketId")]
    public string? TicketId { get; set; }
}