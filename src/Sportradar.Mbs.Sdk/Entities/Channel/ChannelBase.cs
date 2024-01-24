using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sportradar.Mbs.Sdk.Entities.Channel;

[JsonConverter(typeof(ChannelBaseJsonConverter))]
public abstract class ChannelBase
{
}

public class ChannelBaseJsonConverter : JsonConverter<ChannelBase>
{
    public override ChannelBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        var type = root.GetProperty("type").GetString();

        ChannelBase? result = type switch
        {
            "tv-app" => JsonSerializer.Deserialize<TvAppChannel>(root.GetRawText()),
            "agent" => JsonSerializer.Deserialize<AgentChannel>(root.GetRawText()),
            "mobile-app" => JsonSerializer.Deserialize<MobileAppChannel>(root.GetRawText()),
            "phone" => JsonSerializer.Deserialize<PhoneChannel>(root.GetRawText()),
            "call-centre" => JsonSerializer.Deserialize<CallCentreChannel>(root.GetRawText()),
            "sms" => JsonSerializer.Deserialize<SmsChannel>(root.GetRawText()),
            "mobile" => JsonSerializer.Deserialize<MobileChannel>(root.GetRawText()),
            "terminal" => JsonSerializer.Deserialize<TerminalChannel>(root.GetRawText()),
            "retail" => JsonSerializer.Deserialize<RetailChannel>(root.GetRawText()),
            "internet" => JsonSerializer.Deserialize<InternetChannel>(root.GetRawText()),
            _ => throw new JsonException("Unknown type of ChannelBase: " + type)
        };
        return result ?? throw new NullReferenceException("Null ChannelBase: " + type);
    }

    public override void Write(Utf8JsonWriter writer, ChannelBase value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}