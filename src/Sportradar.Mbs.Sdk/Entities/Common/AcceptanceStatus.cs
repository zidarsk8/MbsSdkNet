using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Common;

[JsonConverter(typeof(AcceptanceStatusJsonConverter))]
public enum AcceptanceStatus
{
    REJECTED,
    ACCEPTED
}

public class AcceptanceStatusJsonConverter : JsonConverter<AcceptanceStatus>
{
    public override AcceptanceStatus Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var jsonVal = reader.GetString();
        return jsonVal switch
        {
            "rejected" => AcceptanceStatus.REJECTED,
            "accepted" => AcceptanceStatus.ACCEPTED,
            _ => throw new JsonException("Unknown type of AcceptanceStatus: " + jsonVal)
        };
    }

    public override void Write(Utf8JsonWriter writer, AcceptanceStatus value, JsonSerializerOptions options)
    {
        var jsonVal = value switch
        {
            AcceptanceStatus.REJECTED => "rejected",
            AcceptanceStatus.ACCEPTED => "accepted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, null)
        };
        writer.WriteStringValue(jsonVal);
    }
}