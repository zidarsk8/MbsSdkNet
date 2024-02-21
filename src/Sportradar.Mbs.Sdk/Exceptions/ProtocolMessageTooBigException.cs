namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when a protocol message exceeds the maximum allowed size.
/// </summary>
public class ProtocolMessageTooBigException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocolMessageTooBigException"/> class.
    /// </summary>
    public ProtocolMessageTooBigException()
        : base(ExceptionCode.ProtocolMessageTooBig, "Max message size is 120kB", null)
    {
    }
}