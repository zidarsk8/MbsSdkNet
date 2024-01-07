using System.Threading.Channels;
using Com.Sportradar.Mbs.Sdk.Internal.Config;
using Com.Sportradar.Mbs.Sdk.Internal.Connection.Messages.Base;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;

namespace Com.Sportradar.Mbs.Sdk.Internal.Connection;

internal class ConnectionProvider : IDisposable
{
    private readonly IConnectionProviderConfig _config;
    private readonly TokenProvider _tokenProvider;
    private readonly WebSocketConnection[] _wsConnections;

    internal ConnectionProvider(
        Channel<WsInputMessage> inputBuffer, Channel<WsOutputMessage> outputBuffer, ImmutableConfig config)
    {
        _config = config;
        _tokenProvider = new TokenProvider(config);
        _wsConnections = new WebSocketConnection[_config.WsNumberOfConnections];
        for (var i = 0; i < _config.WsNumberOfConnections; i++)
            _wsConnections[i] = new WebSocketConnection(inputBuffer, outputBuffer, _tokenProvider, config);
    }

    public void Dispose()
    {
        foreach (var wsConnection in _wsConnections) ExcSuppress.Dispose(wsConnection);

        ExcSuppress.Dispose(_tokenProvider);
    }

    internal async Task ConnectAsync(CancellationToken cancellationToken)
    {
        List<Task> tasks = new();
        foreach (var wsConnection in _wsConnections)
            tasks.Add(wsConnection.ConnectAsync(cancellationToken));
        await Task.WhenAll(tasks).ConfigureAwait(false);
    }
}