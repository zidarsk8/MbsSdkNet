namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when the protocol send fails.
/// </summary>
public class ProtocolSendFailedException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocolSendFailedException"/> class with the specified cause.
    /// </summary>
    /// <param name="cause">The exception that caused the protocol send failure.</param>
    public ProtocolSendFailedException(Exception cause)
        : base(ExceptionCode.ProtocolSendFailed, "Protocol send failed", cause)
    {
    }
}