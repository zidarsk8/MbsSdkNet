using Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

namespace Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages;

internal class SentWsOutputMessage : WsOutputMessage
{
    public SentWsOutputMessage(WsInputMessage wsInputMessage)
        : base(wsInputMessage.CorrelationId)
    {
        WsInputMessage = wsInputMessage;
    }

    internal WsInputMessage WsInputMessage { get; }
}