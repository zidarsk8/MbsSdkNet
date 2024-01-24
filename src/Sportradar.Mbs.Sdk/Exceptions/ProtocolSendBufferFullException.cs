namespace Sportradar.Mbs.Sdk.Exceptions;

public class ProtocolSendBufferFullException : SdkException
{
    public ProtocolSendBufferFullException()
        : base(ExceptionCode.ProtocolSendBufferFull, "Send buffer is full.", null)
    {
    }
}