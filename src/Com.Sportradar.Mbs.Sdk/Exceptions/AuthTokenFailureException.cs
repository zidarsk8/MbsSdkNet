namespace Com.Sportradar.Mbs.Sdk.Exceptions;

public class AuthTokenFailureException : SdkException
{
    public AuthTokenFailureException(Exception cause)
        : base(ExceptionCode.AuthTokenFailure, "Get auth token failed", cause)
    {
    }

    public AuthTokenFailureException(string message)
        : base(ExceptionCode.AuthTokenFailure, message, null)
    {
    }
}