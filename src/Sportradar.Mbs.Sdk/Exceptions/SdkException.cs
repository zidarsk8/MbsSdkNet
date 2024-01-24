namespace Sportradar.Mbs.Sdk.Exceptions;

public abstract class SdkException : Exception
{
    protected SdkException(int code, string message, Exception? innerException) : base(message, innerException)
    {
        Code = code;
    }

    public int Code { get; }
}