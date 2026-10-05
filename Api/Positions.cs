using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Alpaca.Core;
using Alpaca.Core.ErrorResponse;
using Alpaca.Core.Exceptions;
using Alpaca.Core.Models;
using Alpaca.Core.Request;
using Alpaca.Core.Response;
using Alpaca.Errors;
using Alpaca.Models;
using Alpaca.Requests.Positions;

namespace Alpaca.Api;

/// <summary>
/// Head to https://alpaca.markets/docs/api-documentation/api-v2/positions/ to view complete documentation on the Positions API.
/// </summary>
public sealed class Positions
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Positions(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// All Positions
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="PositionClosedReponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="DeleteAllOpenPositionsError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Closes (liquidates) all of the account’s open long and short positions. A response will be provided for each order that is attempted to be cancelled. If an order is no longer cancelable, the server will respond with status 500 and reject the request.
    /// </remarks>
    public Task<IReadOnlyList<PositionClosedReponse>> DeleteAllOpenPositions(DeleteAllOpenPositionsRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/positions"),
            [],
            [new Param("cancel_orders", request.CancelOrders)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<PositionClosedReponse>>(),
            DeleteAllOpenPositionsError.Response,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Position
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Closes (liquidates) the account’s open position for the given symbol. Works for both long and short positions.
    /// </remarks>
    public Task<Order> DeleteOpenPosition(DeleteOpenPositionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/positions/{symbol_or_asset_id}"),
            [new TemplateParam("symbol_or_asset_id", request.SymbolOrAssetId)],
            [new Param("qty", request.Qty), new Param("percentage", request.Percentage)],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<Order>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// All Open Positions
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Position"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// The positions API provides information about an account’s current open positions. The response will include information such as cost basis, shares traded, and market value, which will be updated live as price information is updated. Once a position is closed, it will no longer be queryable through this API
    /// <para>
    /// Retrieves a list of the account’s open positions
    /// </para>
    /// </remarks>
    public Task<IReadOnlyList<Position>> GetAllOpenPositions(RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/positions"),
            [],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Position>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Open Position
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Position"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves the account’s open position for the given symbol or assetId.
    /// </remarks>
    public Task<Position> GetOpenPosition(GetOpenPositionRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/positions/{symbol_or_asset_id}"),
            [new TemplateParam("symbol_or_asset_id", request.SymbolOrAssetId)],
            [],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Position>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            cancellationToken);
}
