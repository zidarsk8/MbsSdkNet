using Com.Sportradar.Mbs.Sdk.Internal.Protocol;
using Com.Sportradar.Mbs.Sdk.Internal.Utils;
using Com.Sportradar.Mbs.Sdk.Protocol;

namespace Com.Sportradar.Mbs.Sdk;

public class MbsSdk : IDisposable
{
    private readonly object _lock;
    private readonly ProtocolProvider _protocolProvider;
    private readonly Action<MbsSdk, Exception>? _unhandledExceptionHandler;

    private bool _connected;
    private bool _disposed;

    public MbsSdk(MbsSdkConfig config)
    {
        _unhandledExceptionHandler = config.UnhandledExceptionHandler;
        _protocolProvider = new ProtocolProvider(config);
        _protocolProvider.UnhandledException += ProtocolProviderOnUnhandledException;
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
            if (_connected) return;
            Task.Run(async () => await _protocolProvider.Connect()).Wait();
            _connected = true;
        }
    }

    private void ProtocolProviderOnUnhandledException(object sender, UnhandledExceptionEventArgs e)
    {
        try
        {
            _unhandledExceptionHandler?.Invoke(this, (e.ExceptionObject as Exception)!);
        }
        catch
        {
        }
    }
}
