namespace Com.Sportradar.Mbs.Sdk.Internal.Utils;

internal static class Extensions
{
    internal static T NotNull<T>(this T? input, string name = "")
    {
        if (input == null) throw new NullReferenceException(name);
        return input;
    }

    internal static T AtLeast<T>(this T input, T min) where T : IComparable<T>
    {
        return min.CompareTo(input) > 0 ? min : input;
    }

    internal static string RandomString()
    {
        return Guid.NewGuid().ToString("N");
    }
}