namespace Com.Sportradar.Mbs.Sdk.Exceptions;

public class ProtocolTimeoutException : SdkException
{
    public ProtocolTimeoutException()
        : base(ExceptionCode.SdkNotConnected, "Response not received in configured time window", null)
    {
    }
}