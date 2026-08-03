using System;
using System.Collections.Generic;
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
/// Head to https://alpaca.markets/docs/api-documentation/api-v2/watchlist/ to view complete documentation on the Watchlist API.
/// </summary>
public sealed class Watchlists
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Watchlists(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Add Asset to Watchlist
    /// </summary>
    /// <param name="watchlistId">watchlist id</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Append an asset for the symbol to the end of watchlist asset list
    /// </remarks>
    public Task<Watchlist> AddAssetToWatchlist(Guid watchlistId,
        AddAssetToWatchlistRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists/{watchlist_id}"),
            [new TemplateParam("watchlist_id", watchlistId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Add Asset to Watchlist By Name
    /// </summary>
    /// <param name="name">name of the watchlist</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Append an asset for the symbol to the end of watchlist asset list
    /// </remarks>
    public Task<Watchlist> AddAssetToWatchlistByName(string name,
        AddAssetToWatchlistRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists:by_name"),
            [],
            [new Param("name", name)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Delete Watchlist By Id
    /// </summary>
    /// <param name="watchlistId">watchlist id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a watchlist. This is a permanent deletion.
    /// </remarks>
    public Task DeleteWatchlistById(Guid watchlistId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists/{watchlist_id}"),
            [new TemplateParam("watchlist_id", watchlistId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Delete Watchlist By Name
    /// </summary>
    /// <param name="name">name of the watchlist</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete a watchlist. This is a permanent deletion.
    /// </remarks>
    public Task DeleteWatchlistByName(string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists:by_name"),
            [],
            [new Param("name", name)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Get Watchlist by ID
    /// </summary>
    /// <param name="watchlistId">watchlist id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a watchlist identified by the ID.
    /// </remarks>
    public Task<Watchlist> GetWatchlistById(Guid watchlistId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists/{watchlist_id}"),
            [new TemplateParam("watchlist_id", watchlistId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Get Watchlist by Name
    /// </summary>
    /// <param name="name">name of the watchlist</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns a watchlist by name
    /// </remarks>
    public Task<Watchlist> GetWatchlistByName(string name,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists:by_name"),
            [],
            [new Param("name", name)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Watchlists
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the list of watchlists registered under the account.
    /// </remarks>
    public Task<IReadOnlyList<Watchlist>> GetWatchlists(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Watchlist>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Watchlist
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Create a new watchlist with initial set of assets.
    /// </remarks>
    public Task<Watchlist> PostWatchlist(PostWatchlistRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Symbol from Watchlist
    /// </summary>
    /// <param name="watchlistId">Watchlist ID</param>
    /// <param name="symbol">symbol name to remove from the watchlist content</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Delete one entry for an asset by symbol name
    /// </remarks>
    public Task<Watchlist> RemoveAssetFromWatchlist(Guid watchlistId,
        string symbol,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists/{watchlist_id}/{symbol}"),
            [new TemplateParam("watchlist_id", watchlistId), new TemplateParam("symbol", symbol)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Update Watchlist By Id
    /// </summary>
    /// <param name="watchlistId">watchlist id</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the name and/or content of watchlist
    /// </remarks>
    public Task<Watchlist> UpdateWatchlistById(Guid watchlistId,
        PostWatchlistRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists/{watchlist_id}"),
            [new TemplateParam("watchlist_id", watchlistId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Update Watchlist By Name
    /// </summary>
    /// <param name="name">name of the watchlist</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Watchlist"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Update the name and/or content of watchlist
    /// </remarks>
    public Task<Watchlist> UpdateWatchlistByName(string name,
        PostWatchlistRequest? body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/watchlists:by_name"),
            [],
            [new Param("name", name)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Put,
            JsonRequest.Create(body),
            JsonResponse.Create<Watchlist>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);
}
