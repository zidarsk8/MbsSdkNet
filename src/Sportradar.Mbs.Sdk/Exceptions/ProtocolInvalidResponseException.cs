namespace Sportradar.Mbs.Sdk.Exceptions;

public class ProtocolInvalidResponseException : SdkException
{
    public ProtocolInvalidResponseException(string content)
        : base(ExceptionCode.ProtocolInvalidResponse, content, null)
    {
    }
}