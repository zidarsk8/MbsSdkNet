using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Balancechangesource;

/// <summary>
/// Represents a balance change source related to a ticket.
/// </summary>
public class TicketBalanceChangeSource : BalanceChangeSourceBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    /// <summary>
    /// Gets or sets the action of the ticket producing balance change.
    /// </summary>
    [JsonPropertyName("action")]
    public TicketBalanceChangeAction? Action { get; set; }

    /// <summary>
    /// Gets or sets the ID of the ticket producing balance change.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}