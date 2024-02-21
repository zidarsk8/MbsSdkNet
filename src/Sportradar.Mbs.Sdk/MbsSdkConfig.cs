namespace Sportradar.Mbs.Sdk;

/// <summary>
/// Represents the configuration for the <see cref="MbsSdk"/>
/// </summary>
public class MbsSdkConfig
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MbsSdkConfig"/> class
    /// </summary>
    /// <param name="wsServer">WebSocket server URI</param>
    /// <param name="authServer">Auth server URI</param>
    /// <param name="authClientId">Auth client id</param>
    /// <param name="authClientSecret">Auth client secret</param>
    /// <param name="authAudience">Auth audience</param>
    /// <param name="operatorId">Operator id</param>
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

    /// <summary>
    /// Gets or sets the WebSocket server URI
    /// </summary>
    public Uri WsServer { get; set; }

    /// <summary>
    /// Gets or sets the Auth server URI
    /// </summary>
    public Uri AuthServer { get; set; }

    /// <summary>
    /// Gets or sets the Auth client id
    /// </summary>
    public string AuthClientId { get; set; }

    /// <summary>
    /// Gets or sets the Auth client secret
    /// </summary>
    public string AuthClientSecret { get; set; }

    /// <summary>
    /// Gets or sets the Auth audience
    /// </summary>
    public string AuthAudience { get; set; }

    /// <summary>
    /// Gets or sets the Operator id
    /// </summary>
    public long OperatorId { get; set; }

    /// <summary>
    /// Gets or sets the Auth request timeout
    /// </summary>
    public TimeSpan? AuthRequestTimeout { get; set; }

    /// <summary>
    /// Gets or sets the Protocol connect timeout
    /// </summary>
    public TimeSpan? ProtocolConnectTimeout { get; set; }

    /// <summary>
    /// Gets or sets the Auth retry delay
    /// </summary>
    public TimeSpan? AuthRetryDelay { get; set; }

    /// <summary>
    /// Gets or sets the Protocol max send buffer size
    /// </summary>
    public int? ProtocolMaxSendBufferSize { get; set; }

    /// <summary>
    /// Gets or sets the Protocol enqueue timeout
    /// </summary>
    public TimeSpan? ProtocolEnqueueTimeout { get; set; }

    /// <summary>
    /// Gets or sets the Protocol dequeue timeout
    /// </summary>
    public TimeSpan? ProtocolDequeueTimeout { get; set; }

    /// <summary>
    /// Gets or sets the Protocol receive response timeout
    /// </summary>
    public TimeSpan? ProtocolReceiveResponseTimeout { get; set; }

    /// <summary>
    /// Gets or sets the Protocol retry count
    /// </summary>
    public int? ProtocolRetryCount { get; set; }

    /// <summary>
    /// Gets or sets the number of Protocol dispatchers
    /// </summary>
    public int? ProtocolNumberOfDispatchers { get; set; }

    /// <summary>
    /// Gets or sets the WebSocket reconnect timeout
    /// </summary>
    public TimeSpan? WsReconnectTimeout { get; set; }

    /// <summary>
    /// Gets or sets the WebSocket fetch message timeout
    /// </summary>
    public TimeSpan? WsFetchMessageTimeout { get; set; }

    /// <summary>
    /// Gets or sets the WebSocket send message timeout
    /// </summary>
    public TimeSpan? WsSendMessageTimeout { get; set; }

    /// <summary>
    /// Gets or sets the WebSocket receive message timeout
    /// </summary>
    public TimeSpan? WsReceiveMessageTimeout { get; set; }

    /// <summary>
    /// Gets or sets the WebSocket consumer grace timeout
    /// </summary>
    public TimeSpan? WsConsumerGraceTimeout { get; set; }

    /// <summary>
    /// Gets or sets the WebSocket refresh connection timeout
    /// </summary>
    public TimeSpan? WsRefreshConnectionTimeout { get; set; }

    /// <summary>
    /// Gets or sets the number of WebSocket connections
    /// </summary>
    public int? WsNumberOfConnections { get; set; }

    /// <summary>
    /// Gets or sets the unhandled exception handler
    /// </summary>
    public Action<MbsSdk, Exception>? UnhandledExceptionHandler { get; set; }
}
