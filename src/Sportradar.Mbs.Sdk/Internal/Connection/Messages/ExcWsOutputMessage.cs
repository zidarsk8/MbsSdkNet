using Sportradar.Mbs.Sdk.Exceptions;
using Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

namespace Sportradar.Mbs.Sdk.Internal.Connection.Messages;

internal class ExcWsOutputMessage : WsOutputMessage
{
    public ExcWsOutputMessage(WsInputMessage? inputMessage, SdkException exc)
        : base(inputMessage?.CorrelationId ?? "")
    {
        InputMessage = inputMessage;
        Exception = exc;
    }

    internal WsInputMessage? InputMessage { get; }
    internal SdkException Exception { get; }
}