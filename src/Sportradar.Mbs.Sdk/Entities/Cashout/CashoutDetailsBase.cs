using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Cashout;

[JsonConverter(typeof(CashoutDetailsBaseJsonConverter))]
public abstract class CashoutDetailsBase
{
}

public class CashoutDetailsBaseJsonConverter : JsonConverter<CashoutDetailsBase>
{
    public override CashoutDetailsBase Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        CashoutDetailsBase? result = type switch
        {
            "bet" => JsonSerializer.Deserialize<BetCashoutDetails>(root.GetRawText()),
            "ticket-partial" => JsonSerializer.Deserialize<TicketPartialCashoutDetails>(root.GetRawText()),
            "ticket" => JsonSerializer.Deserialize<TicketCashoutDetails>(root.GetRawText()),
            "bet-partial" => JsonSerializer.Deserialize<BetPartialCashoutDetails>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of CashoutDetailsBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null CashoutDetailsBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, CashoutDetailsBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}