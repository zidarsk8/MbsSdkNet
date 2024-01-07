using System.Text.Json.Serialization;

namespace Com.Sportradar.Mbs.Sdk.Entities.Channel;

public class AgentChannel : ChannelBase
{
    [JsonInclude]
    [JsonPropertyName("type")]
    private string Type => "agent";

    [JsonPropertyName("lang")]
    public string? Lang { get; set; }
}