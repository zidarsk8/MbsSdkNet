namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when a protocol timeout occurs.
/// </summary>
public class ProtocolTimeoutException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocolTimeoutException"/> class.
    /// </summary>
    public ProtocolTimeoutException()
        : base(ExceptionCode.SdkNotConnected, "Response not received in configured time window", null)
    {
    }
}