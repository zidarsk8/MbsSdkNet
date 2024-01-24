namespace Sportradar.Mbs.Sdk.Exceptions;

public class ServerErrorResponseException : SdkException
{
    public ServerErrorResponseException(int errorCode, string errorMessage)
        : base(ExceptionCode.ServerErrorResponse, errorMessage, null)
    {
        ErrorCode = errorCode;
    }

    public int ErrorCode { get; }
}