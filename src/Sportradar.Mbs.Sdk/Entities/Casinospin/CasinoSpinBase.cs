using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Casinospin;

[JsonConverter(typeof(CasinoSpinBaseJsonConverter))]
public abstract class CasinoSpinBase
{
}

public class CasinoSpinBaseJsonConverter : JsonConverter<CasinoSpinBase>
{
    public override CasinoSpinBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        CasinoSpinBase? result = type switch
        {
            "bonus" => JsonSerializer.Deserialize<BonusCasinoSpin>(root.GetRawText()),
            "ordinary" => JsonSerializer.Deserialize<OrdinaryCasinoSpin>(root.GetRawText()),
            "free" => JsonSerializer.Deserialize<FreeCasinoSpin>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of CasinoSpinBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null CasinoSpinBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, CasinoSpinBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}