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
using Alpaca.Models.Enums;

namespace Alpaca.Api;

/// <summary>
/// Head to https://alpaca.markets/docs/api-documentation/api-v2/orders/ to view complete documentation on the Orders API.
/// </summary>
public sealed class Orders
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal Orders(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// All Orders
    /// </summary>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="CanceledOrderResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteAllOrdersError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Attempts to cancel all open orders. A response will be provided for each order that is attempted to be cancelled. If an order is no longer cancelable, the server will respond with status 500 and reject the request.
    /// </remarks>
    public Task<IReadOnlyList<CanceledOrderResponse>> DeleteAllOrders(RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<CanceledOrderResponse>>(),
            DeleteAllOrdersErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Order by Order ID
    /// </summary>
    /// <param name="orderId">order id</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="DeleteOrderByOrderIdError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Attempts to cancel an Open Order. If the order is no longer cancelable, the request will be rejected with status 422; otherwise accepted with return status 204.
    /// </remarks>
    public Task DeleteOrderByOrderId(Guid orderId,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}"),
            [new TemplateParam("order_id", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Delete,
            EmptyBody.Instance,
            VoidResponse.Instance,
            DeleteOrderByOrderIdErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// All Orders
    /// </summary>
    /// <param name="status">Order status to be queried. open, closed or all. Defaults to open.</param>
    /// <param name="limit">The maximum number of orders in response. Defaults to 50 and max is 500.</param>
    /// <param name="after">The response will include only ones submitted after this timestamp (exclusive.)</param>
    /// <param name="until">The response will include only ones submitted until this timestamp (exclusive.)</param>
    /// <param name="direction">The chronological order of response based on the submission time. asc or desc. Defaults to desc.</param>
    /// <param name="nested">If true, the result will roll up multi-leg orders under the legs field of primary order.</param>
    /// <param name="symbols">A comma-separated list of symbols to filter by (ex. “AAPL,TSLA,MSFT”). A currency pair is required for crypto orders (ex. “BTCUSD,BCHUSD,LTCUSD,ETCUSD”).</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a list of orders for the account, filtered by the supplied query parameters.
    /// </remarks>
    public Task<IReadOnlyList<Order>> GetAllOrders(Status1? status,
        int? limit,
        string? after,
        string? until,
        Direction? direction,
        bool? nested,
        string? symbols,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders"),
            [],
            [new Param("status", status),
                new Param("limit", limit),
                new Param("after", after),
                new Param("until", until),
                new Param("direction", direction),
                new Param("nested", nested),
                new Param("symbols", symbols)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Order>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Order by Order ID
    /// </summary>
    /// <param name="orderId">order id</param>
    /// <param name="nested">If true, the result will roll up multi-leg orders under the legs field of primary order.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Retrieves a single order for the given order_id.
    /// </remarks>
    public Task<Order> GetOrderByOrderId(Guid orderId,
        bool? nested,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}"),
            [new TemplateParam("order_id", orderId)],
            [new Param("nested", nested)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<Order>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Order
    /// </summary>
    /// <param name="orderId">order id</param>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Replaces a single order with updated parameters. Each parameter overrides the corresponding attribute of the existing order. The other attributes remain the same as the existing order.
    /// <para>
    /// A success return code from a replaced order does NOT guarantee the existing open order has been replaced. If the existing open order is filled before the replacing (new) order reaches the execution venue, the replacing (new) order is rejected, and these events are sent in the trade_updates stream channel.
    /// </para>
    /// <para>
    /// While an order is being replaced, buying power is reduced by the larger of the two orders that have been placed (the old order being replaced, and the newly placed order to replace it). If you are replacing a buy entry order with a higher limit price than the original order, the buying power is calculated based on the newly placed order. If you are replacing it with a lower limit price, the buying power is calculated based on the old order.
    /// </para>
    /// </remarks>
    public Task<Order> PatchOrderByOrderId(Guid orderId,
        PatchOrderRequest body,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders/{order_id}"),
            [new TemplateParam("order_id", orderId)],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            new HttpMethod("PATCH"),
            JsonRequest.Create(body),
            JsonResponse.Create<Order>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Order
    /// </summary>
    /// <param name="body"></param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="Order"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="PostOrderError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Places a new order for the given account. An order request may be rejected if the account is not authorized for trading, or if the tradable balance is insufficient to fill the order..
    /// </remarks>
    public Task<Order> PostOrder(Order body, RequestOptions? requestOptions = null, CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/orders"),
            [],
            [],
            [new HeaderParam("Idempotency-Key", Guid.NewGuid())],
            HttpMethod.Post,
            JsonRequest.Create(body),
            JsonResponse.Create<Order>(),
            PostOrderErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);
}
