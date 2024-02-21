namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when a server responds with an error.
/// </summary>
public class ServerErrorResponseException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ServerErrorResponseException"/> class with the specified error code and error message.
    /// </summary>
    /// <param name="errorCode">The error code returned by the server.</param>
    /// <param name="errorMessage">The error message returned by the server.</param>
    public ServerErrorResponseException(int errorCode, string errorMessage)
        : base(ExceptionCode.ServerErrorResponse, errorMessage, null)
    {
        ErrorCode = errorCode;
    }

    /// <summary>
    /// Gets the error code returned by the server.
    /// </summary>
    public int ErrorCode { get; }
}