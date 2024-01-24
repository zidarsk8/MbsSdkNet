using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Cancellation;

[JsonConverter(typeof(CancelDetailsBaseJsonConverter))]
public abstract class CancelDetailsBase
{
}

public class CancelDetailsBaseJsonConverter : JsonConverter<CancelDetailsBase>
{
    public override CancelDetailsBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        CancelDetailsBase? result = type switch
        {
            "bet" => JsonSerializer.Deserialize<BetCancelDetails>(root.GetRawText()),
            "reoffer" => JsonSerializer.Deserialize<ReofferCancelDetails>(root.GetRawText()),
            "ticket-partial" => JsonSerializer.Deserialize<TicketPartialCancelDetails>(root.GetRawText()),
            "ticket" => JsonSerializer.Deserialize<TicketCancelDetails>(root.GetRawText()),
            "bet-partial" => JsonSerializer.Deserialize<BetPartialCancelDetails>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of CancelDetailsBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null CancelDetailsBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, CancelDetailsBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}