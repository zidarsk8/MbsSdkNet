using System.Text.Json;
using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Common;

[JsonConverter(typeof(BalanceChangeStatusJsonConverter))]
public enum BalanceChangeStatus
{
    VALID,
    INVALID
}

public class BalanceChangeStatusJsonConverter : JsonConverter<BalanceChangeStatus>
{
    public override BalanceChangeStatus Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        var jsonVal = reader.GetString();
        return jsonVal switch
        {
            "valid" => BalanceChangeStatus.VALID,
            "invalid" => BalanceChangeStatus.INVALID,
            _ => throw new JsonException("Unknown type of BalanceChangeStatus: " + jsonVal)
        };
    }

    public override void Write(Utf8JsonWriter writer, BalanceChangeStatus value, JsonSerializerOptions options)
    {
        var jsonVal = value switch
        {
            BalanceChangeStatus.VALID => "valid",
            BalanceChangeStatus.INVALID => "invalid",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
        writer.WriteStringValue(jsonVal);
    }
}