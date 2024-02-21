namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents a base class for SDK exceptions.
/// </summary>
public abstract class SdkException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SdkException"/> class with the specified error code, message, and inner exception.
    /// </summary>
    /// <param name="code">The error code associated with the exception.</param>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference if no inner exception is specified.</param>
    protected SdkException(int code, string message, Exception? innerException) : base(message, innerException)
    {
        Code = code;
    }

    /// <summary>
    /// Gets the error code associated with the exception.
    /// </summary>
    public int Code { get; }
}