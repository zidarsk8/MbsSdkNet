using System.Text.Json;
using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Balancechangesource;

[JsonConverter(typeof(TicketBalanceChangeActionJsonConverter))]
public enum TicketBalanceChangeAction
{
    PAYOUT,
    PLACE
}

public class TicketBalanceChangeActionJsonConverter : JsonConverter<TicketBalanceChangeAction>
{
    public override TicketBalanceChangeAction Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        var jsonVal = reader.GetString();
        return jsonVal switch
        {
            "payout" => TicketBalanceChangeAction.PAYOUT,
            "place" => TicketBalanceChangeAction.PLACE,
            _ => throw new JsonException("Unknown type of TicketBalanceChangeAction: " + jsonVal)
        };
    }

    public override void Write(Utf8JsonWriter writer, TicketBalanceChangeAction value, JsonSerializerOptions options)
    {
        var jsonVal = value switch
        {
            TicketBalanceChangeAction.PAYOUT => "payout",
            TicketBalanceChangeAction.PLACE => "place",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
        writer.WriteStringValue(jsonVal);
    }
}