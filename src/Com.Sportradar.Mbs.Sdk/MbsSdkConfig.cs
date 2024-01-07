namespace Com.Sportradar.Mbs.Sdk;

public class MbsSdkConfig
{
    public MbsSdkConfig(
        Uri wsServer,
        Uri authServer,
        string authClientId,
        string authClientSecret,
        string authAudience,
        long operatorId)
    {
        WsServer = wsServer;
        AuthServer = authServer;
        AuthClientId = authClientId;
        AuthClientSecret = authClientSecret;
        AuthAudience = authAudience;
        OperatorId = operatorId;
    }

    public Uri WsServer { get; set; }
    public Uri AuthServer { get; set; }
    public string AuthClientId { get; set; }
    public string AuthClientSecret { get; set; }
    public string AuthAudience { get; set; }
    public long OperatorId { get; set; }
    public TimeSpan? AuthRequestTimeout { get; set; }
    public TimeSpan? ProtocolConnectTimeout { get; set; }
    public TimeSpan? AuthRetryDelay { get; set; }
    public int? ProtocolMaxSendBufferSize { get; set; }
    public TimeSpan? ProtocolEnqueueTimeout { get; set; }
    public TimeSpan? ProtocolDequeueTimeout { get; set; }
    public TimeSpan? ProtocolReceiveResponseTimeout { get; set; }
    public int? ProtocolRetryCount { get; set; }
    public int? ProtocolNumberOfDispatchers { get; set; }
    public TimeSpan? WsReconnectTimeout { get; set; }
    public TimeSpan? WsFetchMessageTimeout { get; set; }
    public TimeSpan? WsSendMessageTimeout { get; set; }
    public TimeSpan? WsReceiveMessageTimeout { get; set; }
    public TimeSpan? WsConsumerGraceTimeout { get; set; }
    public TimeSpan? WsRefreshConnectionTimeout { get; set; }
    public int? WsNumberOfConnections { get; set; }
}