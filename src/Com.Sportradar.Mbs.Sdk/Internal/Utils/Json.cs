using System.Text.Json;
using System.Text.Json.Serialization;
using Com.Sportradar.Mbs.Sdk.Entities.Internal;

namespace Com.Sportradar.Mbs.Sdk.Internal.Utils;

internal static class Json
{
    private static readonly JsonSerializerOptions Options = new()
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
    };

    internal static string SerializeRequest(this Request request)
    {
        return JsonSerializer.Serialize(request.NotNull(nameof(request)), Options);
    }

    internal static Request DeserializeRequest(this string json)
    {
        return JsonSerializer.Deserialize<Request>(json, Options).NotNull(nameof(Request));
    }

    internal static string SerializeResponse(this Response response)
    {
        return JsonSerializer.Serialize(response.NotNull(nameof(response)), Options);
    }

    internal static Response DeserializeResponse(this string json)
    {
        return JsonSerializer.Deserialize<Response>(json, Options).NotNull(nameof(Response));
    }
}