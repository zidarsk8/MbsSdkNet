namespace Sportradar.Mbs.Sdk.Internal.Utils;

internal static class ExcSuppress
{
    internal static void Dispose(IDisposable? disposable)
    {
        try
        {
            disposable?.Dispose();
        }
        catch
        {
        }
    }

    internal static void Invoke(Action? action)
    {
        try
        {
            action?.Invoke();
        }
        catch
        {
        }
    }
}