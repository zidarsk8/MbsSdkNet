using System.Text.Json.Serialization;
using Sportradar.Mbs.Sdk.Entities.Common;

namespace Sportradar.Mbs.Sdk.Entities.Request;

/// <summary>
/// Represents a request to inform the system about a ticket.
/// </summary>
public class TicketInformRequest : ContentRequestBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket-inform";

    /// <summary>
    /// Gets or sets the ticket request.
    /// </summary>
    [JsonPropertyName("ticket")]
    public TicketRequest? Ticket { get; set; }

    /// <summary>
    /// Gets or sets the array of bet validations.
    /// </summary>
    [JsonPropertyName("betValidations")]
    public BetValidation[]? BetValidations { get; set; }
}