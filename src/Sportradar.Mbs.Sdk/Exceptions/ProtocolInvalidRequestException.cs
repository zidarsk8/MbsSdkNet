namespace Sportradar.Mbs.Sdk.Exceptions;

public class ProtocolInvalidRequestException : SdkException
{
    public ProtocolInvalidRequestException(string content)
        : base(ExceptionCode.ProtocolInvalidRequest, content, null)
    {
    }
}