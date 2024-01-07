using Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

namespace Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages;

internal class SendWsInputMessage : WsInputMessage
{
    public SendWsInputMessage(string correlationId, List<byte[]> content)
        : base(correlationId)
    {
        Content = content;
    }

    internal List<byte[]> Content { get; }
}