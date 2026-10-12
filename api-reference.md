# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [AlpacaClient](src/Alpaca/AlpacaClient.cs)

## AccountActivities

> Source: [AccountActivities](src/Alpaca/Api/AccountActivities.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V2AccountActivitiesResponse&gt;&gt; GetAccountActivities(GetAccountActivitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns account activity entries for many types of activities.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountActivities.GetAccountActivities(new GetAccountActivitiesRequest
    {
        Direction = Direction.Desc,
        ActivityTypes = "FILL",
    });
    // TODO: Handle 'response' of type IReadOnlyList<V2AccountActivitiesResponse>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountActivitiesRequest](src/Alpaca/Requests/AccountActivities/GetAccountActivitiesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V2AccountActivitiesResponse](src/Alpaca/Models/AnyOf/V2AccountActivitiesResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V2AccountActivitiesResponse1&gt;&gt; GetAccountActivitiesByActivityType(GetAccountActivitiesByActivityTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns account activity entries for a specific type of activity.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountActivities.GetAccountActivitiesByActivityType(
        new GetAccountActivitiesByActivityTypeRequest
        {
            ActivityType = "some example string",
            Direction = Direction.Desc,
        });
    // TODO: Handle 'response' of type IReadOnlyList<V2AccountActivitiesResponse1>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountActivitiesByActivityTypeRequest](src/Alpaca/Requests/AccountActivities/GetAccountActivitiesByActivityTypeRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V2AccountActivitiesResponse1](src/Alpaca/Models/AnyOf/V2AccountActivitiesResponse1.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountConfigurationsApi

> Source: [AccountConfigurationsApi](src/Alpaca/Api/AccountConfigurationsApi.cs)

<details>
<summary><code>Task&lt;AccountConfigurations&gt; GetAccountConfig(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

gets the current account configuration values

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountConfigurationsApi.GetAccountConfig();
    // TODO: Handle 'response' of type AccountConfigurations
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountConfigurations](src/Alpaca/Models/AccountConfigurations.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountConfigurations&gt; PatchAccountConfig(PatchAccountConfigRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates and returns the current account configuration values

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.AccountConfigurationsApi.PatchAccountConfig(new PatchAccountConfigRequest());
    // TODO: Handle 'response' of type AccountConfigurations
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchAccountConfigRequest](src/Alpaca/Requests/AccountConfigurationsApi/PatchAccountConfigRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountConfigurations](src/Alpaca/Models/AccountConfigurations.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Accounts

> Source: [Accounts](src/Alpaca/Api/Accounts.cs)

<details>
<summary><code>Task&lt;Account&gt; GetAccount(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the account associated with the API key.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Accounts.GetAccount();
    // TODO: Handle 'response' of type Account
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Account](src/Alpaca/Models/Account.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CalendarApi

> Source: [CalendarApi](src/Alpaca/Api/CalendarApi.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Calendar&gt;&gt; GetCalendar(GetCalendarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the market calendar.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.CalendarApi.GetCalendar(new GetCalendarRequest());
    // TODO: Handle 'response' of type IReadOnlyList<Calendar>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCalendarRequest](src/Alpaca/Requests/CalendarApi/GetCalendarRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Calendar](src/Alpaca/Models/Calendar.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClockApi

> Source: [ClockApi](src/Alpaca/Api/ClockApi.cs)

<details>
<summary><code>Task&lt;Clock&gt; GetClock(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The clock API serves the current market timestamp, whether or not the market is currently open, as well as the times of the next market open and close.

Returns the market clock.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.ClockApi.GetClock();
    // TODO: Handle 'response' of type Clock
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Clock](src/Alpaca/Models/Clock.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](src/Alpaca/Api/Orders.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CanceledOrderResponse&gt;&gt; DeleteAllOrders(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Attempts to cancel all open orders. A response will be provided for each order that is attempted to be cancelled. If an order is no longer cancelable, the server will respond with status 500 and reject the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.DeleteAllOrders();
    // TODO: Handle 'response' of type IReadOnlyList<CanceledOrderResponse>
}
catch (ApiException<DeleteAllOrdersError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[CanceledOrderResponse](src/Alpaca/Models/CanceledOrderResponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[DeleteAllOrdersError](src/Alpaca/Errors/DeleteAllOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteOrderByOrderId(DeleteOrderByOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Attempts to cancel an Open Order. If the order is no longer cancelable, the request will be rejected with status 422; otherwise accepted with return status 204.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Orders.DeleteOrderByOrderId(new DeleteOrderByOrderIdRequest
    {
        OrderId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
    });
}
catch (ApiException<DeleteOrderByOrderIdError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOrderByOrderIdRequest](src/Alpaca/Requests/Orders/DeleteOrderByOrderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[DeleteOrderByOrderIdError](src/Alpaca/Errors/DeleteOrderByOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Order&gt;&gt; GetAllOrders(GetAllOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a list of orders for the account, filtered by the supplied query parameters.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.GetAllOrders(new GetAllOrdersRequest { Status = Status1.Open });
    // TODO: Handle 'response' of type IReadOnlyList<Order>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAllOrdersRequest](src/Alpaca/Requests/Orders/GetAllOrdersRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Order](src/Alpaca/Models/Order.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; GetOrderByOrderId(GetOrderByOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves a single order for the given order_id.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.GetOrderByOrderId(new GetOrderByOrderIdRequest
    {
        OrderId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
    });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrderByOrderIdRequest](src/Alpaca/Requests/Orders/GetOrderByOrderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](src/Alpaca/Models/Order.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; PatchOrderByOrderId(PatchOrderByOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Replaces a single order with updated parameters. Each parameter overrides the corresponding attribute of the existing order. The other attributes remain the same as the existing order.

A success return code from a replaced order does NOT guarantee the existing open order has been replaced. If the existing open order is filled before the replacing (new) order reaches the execution venue, the replacing (new) order is rejected, and these events are sent in the trade_updates stream channel. 

While an order is being replaced, buying power is reduced by the larger of the two orders that have been placed (the old order being replaced, and the newly placed order to replace it). If you are replacing a buy entry order with a higher limit price than the original order, the buying power is calculated based on the newly placed order. If you are replacing it with a lower limit price, the buying power is calculated based on the old order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PatchOrderByOrderId(new PatchOrderByOrderIdRequest
    {
        OrderId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
        Body = new PatchOrderRequest(),
    });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchOrderByOrderIdRequest](src/Alpaca/Requests/Orders/PatchOrderByOrderIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](src/Alpaca/Models/Order.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; PostOrder(PostOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Places a new order for the given account. An order request may be rejected if the account is not authorized for trading, or if the tradable balance is insufficient to fill the order..

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.PostOrder(new PostOrderRequest
    {
        Body = new Order
        {
            Symbol = "some example string",
            Notional = "some example string",
            Qty = "some example string",
            Type = OrderType.Market,
            Side = OrderSide.Buy,
            TimeInForce = TimeInForce.Day,
        },
    });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<PostOrderError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostOrderRequest](src/Alpaca/Requests/Orders/PostOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](src/Alpaca/Models/Order.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[PostOrderError](src/Alpaca/Errors/PostOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PortfolioHistoryApi

> Source: [PortfolioHistoryApi](src/Alpaca/Api/PortfolioHistoryApi.cs)

<details>
<summary><code>Task&lt;PortfolioHistory&gt; GetAccountPortfolioHistory(GetAccountPortfolioHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns timeseries data about equity and profit/loss (P/L) of the account in requested timespan.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.PortfolioHistoryApi.GetAccountPortfolioHistory(new GetAccountPortfolioHistoryRequest
    {
        DateEnd = DateTimeOffset.Parse("2022-05-15T00:00:00Z"),
    });
    // TODO: Handle 'response' of type PortfolioHistory
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAccountPortfolioHistoryRequest](src/Alpaca/Requests/PortfolioHistoryApi/GetAccountPortfolioHistoryRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortfolioHistory](src/Alpaca/Models/PortfolioHistory.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Positions

> Source: [Positions](src/Alpaca/Api/Positions.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;PositionClosedReponse&gt;&gt; DeleteAllOpenPositions(DeleteAllOpenPositionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes (liquidates) all of the account’s open long and short positions. A response will be provided for each order that is attempted to be cancelled. If an order is no longer cancelable, the server will respond with status 500 and reject the request.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Positions.DeleteAllOpenPositions(new DeleteAllOpenPositionsRequest());
    // TODO: Handle 'response' of type IReadOnlyList<PositionClosedReponse>
}
catch (ApiException<DeleteAllOpenPositionsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteAllOpenPositionsRequest](src/Alpaca/Requests/Positions/DeleteAllOpenPositionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[PositionClosedReponse](src/Alpaca/Models/PositionClosedReponse.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[DeleteAllOpenPositionsError](src/Alpaca/Errors/DeleteAllOpenPositionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; DeleteOpenPosition(DeleteOpenPositionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Closes (liquidates) the account’s open position for the given symbol. Works for both long and short positions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Positions.DeleteOpenPosition(new DeleteOpenPositionRequest
    {
        SymbolOrAssetId = "some example string",
    });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteOpenPositionRequest](src/Alpaca/Requests/Positions/DeleteOpenPositionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](src/Alpaca/Models/Order.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Position&gt;&gt; GetAllOpenPositions(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

The positions API provides information about an account’s current open positions. The response will include information such as cost basis, shares traded, and market value, which will be updated live as price information is updated. Once a position is closed, it will no longer be queryable through this API

Retrieves a list of the account’s open positions

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Positions.GetAllOpenPositions();
    // TODO: Handle 'response' of type IReadOnlyList<Position>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Position](src/Alpaca/Models/Position.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Position&gt; GetOpenPosition(GetOpenPositionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Retrieves the account’s open position for the given symbol or assetId.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Positions.GetOpenPosition(new GetOpenPositionRequest
    {
        SymbolOrAssetId = "some example string",
    });
    // TODO: Handle 'response' of type Position
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOpenPositionRequest](src/Alpaca/Requests/Positions/GetOpenPositionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Position](src/Alpaca/Models/Position.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Watchlists

> Source: [Watchlists](src/Alpaca/Api/Watchlists.cs)

<details>
<summary><code>Task&lt;Watchlist&gt; AddAssetToWatchlist(AddAssetToWatchlistOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Append an asset for the symbol to the end of watchlist asset list

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.AddAssetToWatchlist(new AddAssetToWatchlistOperationRequest
    {
        WatchlistId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddAssetToWatchlistOperationRequest](src/Alpaca/Requests/Watchlists/AddAssetToWatchlistOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; AddAssetToWatchlistByName(AddAssetToWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Append an asset for the symbol to the end of watchlist asset list

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.AddAssetToWatchlistByName(new AddAssetToWatchlistByNameRequest
    {
        Name = "some example string",
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AddAssetToWatchlistByNameRequest](src/Alpaca/Requests/Watchlists/AddAssetToWatchlistByNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteWatchlistById(DeleteWatchlistByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a watchlist. This is a permanent deletion.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Watchlists.DeleteWatchlistById(new DeleteWatchlistByIdRequest
    {
        WatchlistId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
    });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteWatchlistByIdRequest](src/Alpaca/Requests/Watchlists/DeleteWatchlistByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteWatchlistByName(DeleteWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete a watchlist. This is a permanent deletion.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Watchlists.DeleteWatchlistByName(new DeleteWatchlistByNameRequest { Name = "some example string" });
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeleteWatchlistByNameRequest](src/Alpaca/Requests/Watchlists/DeleteWatchlistByNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; GetWatchlistById(GetWatchlistByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a watchlist identified by the ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.GetWatchlistById(new GetWatchlistByIdRequest
    {
        WatchlistId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWatchlistByIdRequest](src/Alpaca/Requests/Watchlists/GetWatchlistByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; GetWatchlistByName(GetWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a watchlist by name

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.GetWatchlistByName(new GetWatchlistByNameRequest
    {
        Name = "some example string",
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetWatchlistByNameRequest](src/Alpaca/Requests/Watchlists/GetWatchlistByNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Watchlist&gt;&gt; GetWatchlists(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns the list of watchlists registered under the account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.GetWatchlists();
    // TODO: Handle 'response' of type IReadOnlyList<Watchlist>
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Watchlist](src/Alpaca/Models/Watchlist.cs)&gt;</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; PostWatchlist(PostWatchlistOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Create a new watchlist with initial set of assets.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.PostWatchlist(new PostWatchlistOperationRequest
    {
        Body = new PostWatchlistRequest { Name = "some example string" },
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PostWatchlistOperationRequest](src/Alpaca/Requests/Watchlists/PostWatchlistOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; RemoveAssetFromWatchlist(RemoveAssetFromWatchlistRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete one entry for an asset by symbol name

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.RemoveAssetFromWatchlist(new RemoveAssetFromWatchlistRequest
    {
        WatchlistId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
        Symbol = "some example string",
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RemoveAssetFromWatchlistRequest](src/Alpaca/Requests/Watchlists/RemoveAssetFromWatchlistRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; UpdateWatchlistById(UpdateWatchlistByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the name and/or content of watchlist

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.UpdateWatchlistById(new UpdateWatchlistByIdRequest
    {
        WatchlistId = Guid.Parse("00000000-0000-0000-0000-000000000000"),
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateWatchlistByIdRequest](src/Alpaca/Requests/Watchlists/UpdateWatchlistByIdRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; UpdateWatchlistByName(UpdateWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Update the name and/or content of watchlist

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Watchlists.UpdateWatchlistByName(new UpdateWatchlistByNameRequest
    {
        Name = "some example string",
    });
    // TODO: Handle 'response' of type Watchlist
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateWatchlistByNameRequest](src/Alpaca/Requests/Watchlists/UpdateWatchlistByNameRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](src/Alpaca/Models/Watchlist.cs)</code>

**OnError**: <code>[ApiException](src/Alpaca/Core/Exceptions/ApiException.cs)&lt;[RawError](src/Alpaca/Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

