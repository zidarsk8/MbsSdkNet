namespace Sportradar.Mbs.Sdk.Exceptions;

public class ProtocolSendFailedException : SdkException
{
    public ProtocolSendFailedException(Exception cause)
        : base(ExceptionCode.ProtocolSendFailed, "Protocol send failed", cause)
    {
    }
}