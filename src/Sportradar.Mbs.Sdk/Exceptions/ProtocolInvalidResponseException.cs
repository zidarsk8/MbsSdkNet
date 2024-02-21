namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when the response received from a protocol is invalid.
/// </summary>
public class ProtocolInvalidResponseException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProtocolInvalidResponseException"/> class with the specified content.
    /// </summary>
    /// <param name="content">The received content which caused the exception.</param>
    public ProtocolInvalidResponseException(string content)
        : base(ExceptionCode.ProtocolInvalidResponse, content, null)
    {
    }
}