using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Balancechangesource;

public class TicketBalanceChangeSource : BalanceChangeSourceBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "ticket";

    [JsonPropertyName("action")]
    public TicketBalanceChangeAction? Action { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}