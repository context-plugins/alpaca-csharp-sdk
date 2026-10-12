using Alpaca.Core.Authentication;
using Alpaca.Core.Authentication.ApiKey;

namespace Alpaca;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKey { get; }
    public IAuthScheme ApiSecret { get; }

    public AuthSchemes(AlpacaClientOptions options)
    {
        ApiKey = ApiKeyHeaderScheme.Create("APCA-API-KEY-ID", options.ApiKey);
        ApiSecret = ApiKeyHeaderScheme.Create("APCA-API-SECRET-KEY", options.ApiSecret);
    }
}
