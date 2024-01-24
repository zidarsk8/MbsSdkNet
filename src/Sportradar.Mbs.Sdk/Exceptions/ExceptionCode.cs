namespace Sportradar.Mbs.Sdk.Exceptions;

public static class ExceptionCode
{
    public const int AuthTokenFailure = 1;
    public const int WebSocketFailure = 2;
    public const int SdkNotConnected = 3;
    public const int ServerErrorResponse = 4;
    public const int ProtocolMessageTooBig = 5;
    public const int ProtocolSendBufferFull = 6;
    public const int ProtocolSendFailed = 7;
    public const int ProtocolInvalidResponse = 8;
    public const int ProtocolInvalidRequest = 9;
}