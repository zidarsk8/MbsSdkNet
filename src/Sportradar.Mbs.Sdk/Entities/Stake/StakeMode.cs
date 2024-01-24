using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Stake;

[JsonConverter(typeof(StakeModeJsonConverter))]
public enum StakeMode
{
    TOTAL,
    UNIT
}

public class StakeModeJsonConverter : JsonConverter<StakeMode>
{
    public override StakeMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var jsonVal = reader.GetString();
        return jsonVal switch
        {
            "total" => StakeMode.TOTAL,
            "unit" => StakeMode.UNIT,
            _ => throw new JsonException("Unknown type of StakeMode: " + jsonVal)
        };
    }

    public override void Write(Utf8JsonWriter writer, StakeMode value, JsonSerializerOptions options)
    {
        var jsonVal = value switch
        {
            StakeMode.TOTAL => "total",
            StakeMode.UNIT => "unit",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
        writer.WriteStringValue(jsonVal);
    }
}