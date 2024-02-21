namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when an invalid request is made in the protocol.
/// </summary>
public class ProtocolInvalidRequestException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocolInvalidRequestException"/> class with the specified content.
    /// </summary>
    /// <param name="content">The original content which caused the exception.</param>
    public ProtocolInvalidRequestException(string content)
        : base(ExceptionCode.ProtocolInvalidRequest, content, null)
    {
    }
}