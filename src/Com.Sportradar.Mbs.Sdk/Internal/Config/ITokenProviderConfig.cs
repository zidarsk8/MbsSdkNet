namespace Com.Sportradar.Mbs.Sdk.Internal.Config;

internal interface ITokenProviderConfig
{
    Uri AuthServer { get; }
    string AuthClientId { get; }
    string AuthClientSecret { get; }
    string AuthAudience { get; }
    TimeSpan AuthRequestTimeout { get; }
    TimeSpan AuthRetryDelay { get; }
}