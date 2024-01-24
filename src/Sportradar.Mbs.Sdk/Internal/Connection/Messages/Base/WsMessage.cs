namespace Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;

internal abstract class WsMessage
{
    protected WsMessage(string correlationId)
    {
        CorrelationId = correlationId;
    }

    internal string CorrelationId { get; }
}