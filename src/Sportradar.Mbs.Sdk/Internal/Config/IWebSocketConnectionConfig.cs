namespace Sportradar.Mbs.Sdk.Internal.Config;

internal interface IWebSocketConnectionConfig
{
    Uri WsServer { get; }
    TimeSpan WsReconnectTimeout { get; }
    TimeSpan WsFetchMessageTimeout { get; }
    TimeSpan WsSendMessageTimeout { get; }
    TimeSpan WsReceiveMessageTimeout { get; }
    TimeSpan WsConsumerGraceTimeout { get; }
    TimeSpan WsRefreshConnectionTimeout { get; }
}