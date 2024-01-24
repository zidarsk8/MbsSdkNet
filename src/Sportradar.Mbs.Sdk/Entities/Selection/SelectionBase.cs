using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Selection;

[JsonConverter(typeof(SelectionBaseJsonConverter))]
public abstract class SelectionBase
{
}

public class SelectionBaseJsonConverter : JsonConverter<SelectionBase>
{
    public override SelectionBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        SelectionBase? result = type switch
        {
            "uf" => JsonSerializer.Deserialize<UfSelection>(root.GetRawText()),
            "odds-boost" => JsonSerializer.Deserialize<OddsBoostSelection>(root.GetRawText()),
            "external" => JsonSerializer.Deserialize<ExtSelection>(root.GetRawText()),
            "system" => JsonSerializer.Deserialize<SystemSelection>(root.GetRawText()),
            "ways" => JsonSerializer.Deserialize<WaysSelection>(root.GetRawText()),
            "uf-custom-bet" => JsonSerializer.Deserialize<UfCustomBetSelection>(root.GetRawText()),
            "accumulator" => JsonSerializer.Deserialize<AccumulatorSelection>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of SelectionBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null SelectionBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, SelectionBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}