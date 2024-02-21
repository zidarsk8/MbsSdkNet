namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when the SDK is not connected or is disposed.
/// </summary>
public class SdkNotConnectedException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SdkNotConnectedException"/> class.
    /// </summary>
    public SdkNotConnectedException()
        : base(ExceptionCode.SdkNotConnected, "Sdk is not connected or is disposed", null)
    {
    }
}