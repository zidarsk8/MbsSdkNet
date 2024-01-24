namespace Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

internal abstract class WsOutputMessage : WsMessage
{
    protected WsOutputMessage(string correlationId) : base(correlationId)
    {
    }
}