using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Stake;

[JsonConverter(typeof(StakeBaseJsonConverter))]
public abstract class StakeBase
{
}

public class StakeBaseJsonConverter : JsonConverter<StakeBase>
{
    public override StakeBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        StakeBase? result = type switch
        {
            "free-cash" => JsonSerializer.Deserialize<FreeCashStake>(root.GetRawText()),
            "free-rollover" => JsonSerializer.Deserialize<FreeRolloverStake>(root.GetRawText()),
            "bonus" => JsonSerializer.Deserialize<BonusStake>(root.GetRawText()),
            "free" => JsonSerializer.Deserialize<FreeStake>(root.GetRawText()),
            "cash" => JsonSerializer.Deserialize<CashStake>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of StakeBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null StakeBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, StakeBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}