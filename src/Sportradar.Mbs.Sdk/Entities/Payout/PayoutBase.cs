using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Payout;

/// <summary>
/// Represents the base class for payout entities.
/// </summary>
[JsonConverter(typeof(PayoutBaseJsonConverter))]
public abstract class PayoutBase
{
}

public class PayoutBaseJsonConverter : JsonConverter<PayoutBase>
{
    public override PayoutBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        PayoutBase? result = type switch
        {
            "free" => JsonSerializer.Deserialize<FreePayout>(root.GetRawText()),
            "cash" => JsonSerializer.Deserialize<CashPayout>(root.GetRawText()),
            "withheld" => JsonSerializer.Deserialize<WithheldPayout>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of PayoutBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null PayoutBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, PayoutBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}