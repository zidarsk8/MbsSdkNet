namespace Com.Sportradar.Mbs.Sdk.Exceptions;

public class ProtocolMessageTooBigException : SdkException
{
    public ProtocolMessageTooBigException()
        : base(ExceptionCode.ProtocolMessageTooBig, "Max message size is 120kB", null)
    {
    }
}