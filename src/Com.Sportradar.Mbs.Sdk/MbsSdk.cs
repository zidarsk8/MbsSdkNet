using Com.Sportradar.Mbs.Sdk.Internal.Protocol;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;
using Com.Sportradar.Mbs.Sdk.Protocol;

namespace Com.Sportradar.Mbs.Sdk;

public class MbsSdk : IDisposable
{
    private readonly object _lock;
    private readonly ProtocolProvider _protocolProvider;

    private bool _disposed;

    public MbsSdk(MbsSdkConfig config)
    {
        _protocolProvider = new ProtocolProvider(config);
        _lock = new object();
    }

    public ITicketProtocol TicketProtocol => _protocolProvider.TicketProtocol;

    public void Dispose()
    {
        lock (_lock)
        {
            if (_disposed) return;

            _disposed = true;
            ExcSuppress.Dispose(_protocolProvider);
        }
    }

    public void Connect()
    {
        lock (_lock)
        {
            if (_disposed) throw new ObjectDisposedException(nameof(MbsSdk));
            Task.Run(async () => await _protocolProvider.Connect()).Wait();
        }
    }
}