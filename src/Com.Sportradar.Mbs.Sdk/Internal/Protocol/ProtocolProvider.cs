using System.Threading.Channels;
using Com.Sportradar.Mbs.Sdk.Exceptions;
using Com.Sportradar.Mbs.Sdk.Internal.Config;
using Com.Sportradar.Mbs.Sdk.Internal.Connection;
using Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;

namespace Com.Sportradar.Mbs.Sdk.Internal.Protocol;

internal partial class ProtocolProvider : IDisposable
{
    private readonly IProtocolProviderConfig _config;
    private readonly ConnectionProvider _connectionProvider;
    private readonly Channel<WsInputMessage> _wsInputBuffer;
    private readonly Channel<WsOutputMessage> _wsOutputBuffer;

    private volatile bool _connected;

    internal ProtocolProvider(MbsSdkConfig mbsSdkConfig)
    {
        var config = new ImmutableConfig(mbsSdkConfig);
        _config = config;
        _wsInputBuffer = Channel.CreateBounded<WsInputMessage>(new BoundedChannelOptions(1)
        {
            SingleReader = false,
            SingleWriter = false,
            AllowSynchronousContinuations = false,
            Capacity = 2 * (_config.ProtocolRetryCount + 1) * _config.ProtocolMaxSendBufferSize,
            FullMode = BoundedChannelFullMode.Wait
        });
        _wsOutputBuffer = Channel.CreateBounded<WsOutputMessage>(new BoundedChannelOptions(1)
        {
            SingleReader = false,
            SingleWriter = false,
            AllowSynchronousContinuations = false,
            Capacity = 3 * (_config.ProtocolRetryCount + 1) * _config.ProtocolMaxSendBufferSize,
            FullMode = BoundedChannelFullMode.Wait
        });
        _connectionProvider = new ConnectionProvider(_wsInputBuffer, _wsOutputBuffer, config);
    }

    public void Dispose()
    {
        ExcSuppress.Invoke(() => UnhandledException = null);
        _connected = false;
        ExcSuppress.Invoke(() => _wsInputBuffer.Writer.Complete());
        ExcSuppress.Dispose(_connectionProvider);
    }

    internal async Task Connect()
    {
        using var source = new CancellationTokenSource(_config.ProtocolConnectTimeout);
        await _connectionProvider.ConnectAsync(source.Token).ConfigureAwait(false);
        _connected = true;
        StartDispatchers();
    }

    private void CheckConnected()
    {
        if (!_connected) throw new SdkNotConnectedException();
    }
}