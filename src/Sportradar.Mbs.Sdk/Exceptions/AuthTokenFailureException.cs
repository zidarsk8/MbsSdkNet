namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when there is a failure in obtaining an authentication token.
/// </summary>
public class AuthTokenFailureException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthTokenFailureException"/> class with the specified cause.
    /// </summary>
    /// <param name="cause">The exception that caused the authentication token failure.</param>
    public AuthTokenFailureException(Exception cause)
        : base(ExceptionCode.AuthTokenFailure, "Get auth token failed", cause)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AuthTokenFailureException"/> class with the specified message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public AuthTokenFailureException(string message)
        : base(ExceptionCode.AuthTokenFailure, message, null)
    {
    }
}