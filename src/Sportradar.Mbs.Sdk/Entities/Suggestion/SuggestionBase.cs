using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Suggestion;

[JsonConverter(typeof(SuggestionBaseJsonConverter))]
public abstract class SuggestionBase
{
}

public class SuggestionBaseJsonConverter : JsonConverter<SuggestionBase>
{
    public override SuggestionBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        SuggestionBase? result = type switch
        {
            "reoffer" => JsonSerializer.Deserialize<ReofferSuggestion>(root.GetRawText()),
            "alt-stake" => JsonSerializer.Deserialize<AltStakeSuggestion>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of SuggestionBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null SuggestionBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, SuggestionBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}