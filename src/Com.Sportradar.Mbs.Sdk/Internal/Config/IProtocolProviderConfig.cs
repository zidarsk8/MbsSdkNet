namespace Com.Sportradar.Mbs.Sdk.Internal.Config;

internal interface IProtocolProviderConfig
{
    TimeSpan ProtocolConnectTimeout { get; }
    TimeSpan ProtocolEnqueueTimeout { get; }
    TimeSpan ProtocolDequeueTimeout { get; }
    TimeSpan ProtocolReceiveResponseTimeout { get; }
    int ProtocolMaxSendBufferSize { get; }
    long ProtocolOperatorId { get; }
    int ProtocolRetryCount { get; }
    int ProtocolNumberOfDispatchers { get; }
}