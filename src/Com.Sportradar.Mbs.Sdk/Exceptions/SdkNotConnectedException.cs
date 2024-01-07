namespace Com.Sportradar.Mbs.Sdk.Exceptions;

public class SdkNotConnectedException : SdkException
{
    public SdkNotConnectedException()
        : base(ExceptionCode.SdkNotConnected, "Sdk is not connected or is disposed", null)
    {
    }
}