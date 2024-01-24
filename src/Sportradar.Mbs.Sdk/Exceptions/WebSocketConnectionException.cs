namespace Sportradar.Mbs.Sdk.Exceptions;

public class WebSocketConnectionException : SdkException
{
    public WebSocketConnectionException(Exception cause)
        : base(ExceptionCode.WebSocketFailure, "WebSocket connect failed", cause)
    {
    }

    public WebSocketConnectionException(string message)
        : base(ExceptionCode.WebSocketFailure, message, null)
    {
    }
}