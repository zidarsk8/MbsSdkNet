namespace Com.Sportradar.Mbs.Sdk.Internal.Utils;

internal static class TimeUtils
{
    internal static long NowInUtcMillis()
    {
        return DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    }
}