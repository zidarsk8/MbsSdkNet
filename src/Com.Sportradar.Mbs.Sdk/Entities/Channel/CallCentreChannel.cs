using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Channel;

public class CallCentreChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "call-centre";

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}