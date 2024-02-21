namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when the send buffer is full in the protocol.
/// </summary>
public class ProtocolSendBufferFullException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocolSendBufferFullException"/> class.
    /// </summary>
    public ProtocolSendBufferFullException()
        : base(ExceptionCode.ProtocolSendBufferFull, "Send buffer is full.", null)
    {
    }
}