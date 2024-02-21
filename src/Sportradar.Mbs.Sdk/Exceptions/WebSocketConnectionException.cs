namespace Sportradar.Mbs.Sdk.Exceptions;

/// <summary>
/// Represents an exception that is thrown when a WebSocket connection fails.
/// </summary>
public class WebSocketConnectionException : SdkException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WebSocketConnectionException"/> class with the specified cause.
    /// </summary>
    /// <param name="cause">The exception that caused the WebSocket connection failure.</param>
    public WebSocketConnectionException(Exception cause)
        : base(ExceptionCode.WebSocketFailure, "WebSocket connect failed", cause)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebSocketConnectionException"/> class with the specified error message.
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception.</param>
    public WebSocketConnectionException(string message)
        : base(ExceptionCode.WebSocketFailure, message, null)
    {
    }
}