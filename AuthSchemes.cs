using TraderApi.Core.Authentication;
using TraderApi.Core.Authentication.ApiKey;

namespace TraderApi;

internal sealed class AuthSchemes
{
    public IAuthScheme ApiKey { get; }
    public IAuthScheme ApiSecret { get; }

    public AuthSchemes(TraderApiClientOptions options)
    {
        ApiKey = ApiKeyHeaderScheme.Create("APCA-API-KEY-ID", options.ApiKey);
        ApiSecret = ApiKeyHeaderScheme.Create("APCA-API-SECRET-KEY", options.ApiSecret);
    }
}
