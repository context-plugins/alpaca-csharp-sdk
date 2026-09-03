using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TraderApi.Core;
using TraderApi.Core.ErrorResponse;
using TraderApi.Core.Exceptions;
using TraderApi.Core.Models;
using TraderApi.Core.Request;
using TraderApi.Core.Response;
using TraderApi.Models;

namespace TraderApi.Api;

/// <summary>
/// Head to https://alpaca.markets/docs/api-documentation/api-v2/account-configuration/ to view complete documentation on the Account Configurations API.
/// </summary>
public sealed class AccountConfigurationsApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountConfigurationsApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Account Configurations
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountConfigurations"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// gets the current account configuration values
    /// </remarks>
    public Task<AccountConfigurations> GetAccountConfig(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/account/configurations"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<AccountConfigurations>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Account Configurations
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="AccountConfigurations"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Updates and returns the current account configuration values
    /// </remarks>
    public Task<AccountConfigurations> PatchAccountConfig(AccountConfigurations? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/account/configurations"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<AccountConfigurations>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);
}
