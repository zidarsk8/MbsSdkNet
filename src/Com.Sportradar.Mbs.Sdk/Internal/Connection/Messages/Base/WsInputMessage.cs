namespace Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

internal abstract class WsInputMessage : WsMessage
{
    protected WsInputMessage(string correlationId) : base(correlationId)
    {
    }
}