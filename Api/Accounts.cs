using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Alpaca.Core;
using Alpaca.Core.ErrorResponse;
using Alpaca.Core.Exceptions;
using Alpaca.Core.Request;
using Alpaca.Core.Response;
using Alpaca.Models;

namespace Alpaca.Api;

/// <summary>
/// Head to https://alpaca.markets/docs/api-references/trading-api/account/ to view complete documentation on the Accounts API.
/// </summary>
public sealed class Accounts
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Accounts(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get account
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Account"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the account associated with the API key.
    /// </remarks>
    public Task<Account> GetAccount(RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/account"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Account>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);
}
