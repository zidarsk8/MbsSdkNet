using Com.Sportradar.Mbs.Sdk.Entities.Internal;
using Com.Sportradar.Mbs.Sdk.Entities.Request;
using Com.Sportradar.Mbs.Sdk.Entities.Response;
using Com.Sportradar.Mbs.Sdk.Exceptions;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;

namespace Com.Sportradar.Mbs.Sdk.Internal.Protocol;

internal partial class ProtocolProvider
{
    private async Task<T> ProcessRequestAsync<T>(string operation, ContentRequestBase content)
        where T : ContentResponseBase
    {
        CheckConnected();
        var correlationId = ReserveCorrelationId<T>();
        try
        {
            var request = new Request
            {
                Content = content,
                Operation = operation,
                CorrelationId = correlationId,
                Version = "3.0",
                OperatorId = _config.ProtocolOperatorId,
                TimestampUtc = TimeUtils.NowInUtcMillis()
            };
            return await EnqueueRequestAndAwaitResponseAsync<T>(correlationId, request).ConfigureAwait(false);
        }
        catch (SdkException)
        {
            throw;
        }
        catch (Exception e)
        {
            throw new ProtocolSendFailedException(e);
        }
        finally
        {
            ReleaseCorrelationId(correlationId);
        }
    }
}