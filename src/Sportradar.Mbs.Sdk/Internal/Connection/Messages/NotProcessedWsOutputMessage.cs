using Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

namespace Sportradar.Mbs.Sdk.Internal.Connection.Messages;

internal class NotProcessedWsOutputMessage : WsOutputMessage
{
    public NotProcessedWsOutputMessage(WsInputMessage wsInputMessage)
        : base(wsInputMessage.CorrelationId)
    {
        WsInputMessage = wsInputMessage;
    }

    internal WsInputMessage WsInputMessage { get; }
}