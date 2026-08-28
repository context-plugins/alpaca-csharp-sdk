# Reference

> Source: [AlpacaClient](AlpacaClient.cs)

## AccountActivities

> Source: [AccountActivities](Api/AccountActivities.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V2AccountActivitiesResponse&gt;&gt; GetAccountActivities(DateTimeOffset? date, DateTimeOffset? until, DateTimeOffset? after, Direction? direction, int? pageSize, string? pageToken, string? activityTypes, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.AccountActivities.GetAccountActivities(date,
        until,
        after,
        direction,
        pageSize,
        pageToken,
        activityTypes);
    // TODO: Handle 'response' of type IReadOnlyList<V2AccountActivitiesResponse>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>date</code> | <code>DateTimeOffset?</code> | The date for which you want to see activities. |
| <code>until</code> | <code>DateTimeOffset?</code> | The response will contain only activities submitted before this date. (Cannot be used with date.) |
| <code>after</code> | <code>DateTimeOffset?</code> | The response will contain only activities submitted after this date. (Cannot be used with date.) |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | asc or desc (default desc if unspecified.) |
| <code>pageSize</code> | <code>int?</code> | The maximum number of entries to return in the response. (See the section on paging above.) |
| <code>pageToken</code> | <code>string?</code> | The ID of the end of your current page of results. |
| <code>activityTypes</code> | <code>string?</code> | A comma-separated list of the activity types to include in the response. If unspecified, activities of all types will be returned. See ActivityType model for values |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V2AccountActivitiesResponse](Models/AnyOf/V2AccountActivitiesResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;V2AccountActivitiesResponse1&gt;&gt; GetAccountActivitiesByActivityType(string activityType, DateTimeOffset? date, DateTimeOffset? until, DateTimeOffset? after, Direction? direction, int? pageSize, string? pageToken, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.AccountActivities.GetAccountActivitiesByActivityType(activityType,
        date,
        until,
        after,
        direction,
        pageSize,
        pageToken);
    // TODO: Handle 'response' of type IReadOnlyList<V2AccountActivitiesResponse1>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>activityType</code> | <code>string</code> | The activity type you want to view entries for. A list of valid activity types can be found at the bottom of this page. |
| <code>date</code> | <code>DateTimeOffset?</code> | The date for which you want to see activities. |
| <code>until</code> | <code>DateTimeOffset?</code> | The response will contain only activities submitted before this date. (Cannot be used with date.) |
| <code>after</code> | <code>DateTimeOffset?</code> | The response will contain only activities submitted after this date. (Cannot be used with date.) |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | asc or desc (default desc if unspecified.) |
| <code>pageSize</code> | <code>int?</code> | The maximum number of entries to return in the response. (See the section on paging above.) |
| <code>pageToken</code> | <code>string?</code> | The ID of the end of your current page of results. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[V2AccountActivitiesResponse1](Models/AnyOf/V2AccountActivitiesResponse1.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## AccountConfigurationsApi

> Source: [AccountConfigurationsApi](Api/AccountConfigurationsApi.cs)

<details>
<summary><code>Task&lt;AccountConfigurations&gt; GetAccountConfig(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountConfigurations](Models/AccountConfigurations.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;AccountConfigurations&gt; PatchAccountConfig(AccountConfigurations? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.AccountConfigurationsApi.PatchAccountConfig(body);
    // TODO: Handle 'response' of type AccountConfigurations
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[AccountConfigurations?](Models/AccountConfigurations.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[AccountConfigurations](Models/AccountConfigurations.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Accounts

> Source: [Accounts](Api/Accounts.cs)

<details>
<summary><code>Task&lt;Account&gt; GetAccount(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Account](Models/Account.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## CalendarApi

> Source: [CalendarApi](Api/CalendarApi.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Calendar&gt;&gt; GetCalendar(DateTimeOffset? start, DateTimeOffset? end, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.CalendarApi.GetCalendar(start, end);
    // TODO: Handle 'response' of type IReadOnlyList<Calendar>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>start</code> | <code>DateTimeOffset?</code> | The first date to retrieve data for (inclusive) |
| <code>end</code> | <code>DateTimeOffset?</code> | The last date to retrieve data for (inclusive) |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Calendar](Models/Calendar.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## ClockApi

> Source: [ClockApi](Api/ClockApi.cs)

<details>
<summary><code>Task&lt;Clock&gt; GetClock(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Clock](Models/Clock.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Orders

> Source: [Orders](Api/Orders.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;CanceledOrderResponse&gt;&gt; DeleteAllOrders(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<DeleteAllOrdersError> ex)
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

**OnSuccess**: <code>IReadOnlyList&lt;[CanceledOrderResponse](Models/CanceledOrderResponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteAllOrdersError](Errors/DeleteAllOrdersError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteOrderByOrderId(Guid orderId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    await client.Orders.DeleteOrderByOrderId(orderId);
}
catch (SdkException<DeleteOrderByOrderIdError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>Guid</code> | order id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteOrderByOrderIdError](Errors/DeleteOrderByOrderIdError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Order&gt;&gt; GetAllOrders(Status1? status, int? limit, string? after, string? until, Direction? direction, bool? nested, string? symbols, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Orders.GetAllOrders(status, limit, after, until, direction, nested, symbols);
    // TODO: Handle 'response' of type IReadOnlyList<Order>
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>status</code> | <code>[Status1?](Models/Enums/Status1.cs)</code> | Order status to be queried. open, closed or all. Defaults to open. |
| <code>limit</code> | <code>int?</code> | The maximum number of orders in response. Defaults to 50 and max is 500. |
| <code>after</code> | <code>string?</code> | The response will include only ones submitted after this timestamp (exclusive.) |
| <code>until</code> | <code>string?</code> | The response will include only ones submitted until this timestamp (exclusive.) |
| <code>direction</code> | <code>[Direction?](Models/Enums/Direction.cs)</code> | The chronological order of response based on the submission time. asc or desc. Defaults to desc. |
| <code>nested</code> | <code>bool?</code> | If true, the result will roll up multi-leg orders under the legs field of primary order. |
| <code>symbols</code> | <code>string?</code> | A comma-separated list of symbols to filter by (ex. “AAPL,TSLA,MSFT”). A currency pair is required for crypto orders (ex. “BTCUSD,BCHUSD,LTCUSD,ETCUSD”). |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Order](Models/Order.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; GetOrderByOrderId(Guid orderId, bool? nested, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Orders.GetOrderByOrderId(orderId, nested);
    // TODO: Handle 'response' of type Order
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>Guid</code> | order id |
| <code>nested</code> | <code>bool?</code> | If true, the result will roll up multi-leg orders under the legs field of primary order. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; PatchOrderByOrderId(Guid orderId, PatchOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Orders.PatchOrderByOrderId(orderId, body);
    // TODO: Handle 'response' of type Order
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>orderId</code> | <code>Guid</code> | order id |
| <code>body</code> | <code>[PatchOrderRequest](Models/PatchOrderRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; PostOrder(Order body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Orders.PostOrder(body);
    // TODO: Handle 'response' of type Order
}
catch (SdkException<PostOrderError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[Order](Models/Order.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[PostOrderError](Errors/PostOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## PortfolioHistoryApi

> Source: [PortfolioHistoryApi](Api/PortfolioHistoryApi.cs)

<details>
<summary><code>Task&lt;PortfolioHistory&gt; GetAccountPortfolioHistory(string? period, string? timeframe, DateTimeOffset? dateEnd, string? extendedHours, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.PortfolioHistoryApi.GetAccountPortfolioHistory(period,
        timeframe,
        dateEnd,
        extendedHours);
    // TODO: Handle 'response' of type PortfolioHistory
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>period</code> | <code>string?</code> | The duration of the data in <number> + <unit>, such as 1D, where <unit> can be D for day, W for week, M for month and A for year. Defaults to 1M. |
| <code>timeframe</code> | <code>string?</code> | The resolution of time window. 1Min, 5Min, 15Min, 1H, or 1D. If omitted, 1Min for less than 7 days period, 15Min for less than 30 days, or otherwise 1D. |
| <code>dateEnd</code> | <code>DateTimeOffset?</code> | The date the data is returned up to, in “YYYY-MM-DD” format. Defaults to the current market date (rolls over at the market open if extended_hours is false, otherwise at 7am ET) |
| <code>extendedHours</code> | <code>string?</code> | If true, include extended hours in the result. This is effective only for timeframe less than 1D. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PortfolioHistory](Models/PortfolioHistory.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Positions

> Source: [Positions](Api/Positions.cs)

<details>
<summary><code>Task&lt;IReadOnlyList&lt;PositionClosedReponse&gt;&gt; DeleteAllOpenPositions(bool? cancelOrders, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Positions.DeleteAllOpenPositions(cancelOrders);
    // TODO: Handle 'response' of type IReadOnlyList<PositionClosedReponse>
}
catch (SdkException<DeleteAllOpenPositionsError> ex)
{
    if (ex.Error.TryGetNoContent(out var error))
    {
        // TODO: Handle 'error' of type RawError
    }
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>cancelOrders</code> | <code>bool?</code> | If true is specified, cancel all open orders before liquidating all positions. |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[PositionClosedReponse](Models/PositionClosedReponse.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[DeleteAllOpenPositionsError](Errors/DeleteAllOpenPositionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; DeleteOpenPosition(string symbolOrAssetId, double? qty, double? percentage, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Positions.DeleteOpenPosition(symbolOrAssetId, qty, percentage);
    // TODO: Handle 'response' of type Order
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbolOrAssetId</code> | <code>string</code> | symbol or assetId |
| <code>qty</code> | <code>double?</code> | the number of shares to liquidate. Can accept up to 9 decimal points. Cannot work with percentage |
| <code>percentage</code> | <code>double?</code> | percentage of position to liquidate. Must be between 0 and 100. Would only sell fractional if position is originally fractional. Can accept up to 9 decimal points. Cannot work with qty |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Position&gt;&gt; GetAllOpenPositions(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Position](Models/Position.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Position&gt; GetOpenPosition(string symbolOrAssetId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Positions.GetOpenPosition(symbolOrAssetId);
    // TODO: Handle 'response' of type Position
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>symbolOrAssetId</code> | <code>string</code> | symbol or assetId |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Position](Models/Position.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Watchlists

> Source: [Watchlists](Api/Watchlists.cs)

<details>
<summary><code>Task&lt;Watchlist&gt; AddAssetToWatchlist(Guid watchlistId, AddAssetToWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.AddAssetToWatchlist(watchlistId, body);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>watchlistId</code> | <code>Guid</code> | watchlist id |
| <code>body</code> | <code>[AddAssetToWatchlistRequest?](Models/AddAssetToWatchlistRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; AddAssetToWatchlistByName(string name, AddAssetToWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.AddAssetToWatchlistByName(name, body);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>name</code> | <code>string</code> | name of the watchlist |
| <code>body</code> | <code>[AddAssetToWatchlistRequest?](Models/AddAssetToWatchlistRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteWatchlistById(Guid watchlistId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    await client.Watchlists.DeleteWatchlistById(watchlistId);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>watchlistId</code> | <code>Guid</code> | watchlist id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeleteWatchlistByName(string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    await client.Watchlists.DeleteWatchlistByName(name);
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>name</code> | <code>string</code> | name of the watchlist |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; GetWatchlistById(Guid watchlistId, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.GetWatchlistById(watchlistId);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>watchlistId</code> | <code>Guid</code> | watchlist id |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; GetWatchlistByName(string name, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.GetWatchlistByName(name);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>name</code> | <code>string</code> | name of the watchlist |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;IReadOnlyList&lt;Watchlist&gt;&gt; GetWatchlists(RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>IReadOnlyList&lt;[Watchlist](Models/Watchlist.cs)&gt;</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; PostWatchlist(PostWatchlistRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.PostWatchlist(body);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>body</code> | <code>[PostWatchlistRequest](Models/PostWatchlistRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; RemoveAssetFromWatchlist(Guid watchlistId, string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.RemoveAssetFromWatchlist(watchlistId, symbol);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>watchlistId</code> | <code>Guid</code> | Watchlist ID |
| <code>symbol</code> | <code>string</code> | symbol name to remove from the watchlist content |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; UpdateWatchlistById(Guid watchlistId, PostWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.UpdateWatchlistById(watchlistId, body);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>watchlistId</code> | <code>Guid</code> | watchlist id |
| <code>body</code> | <code>[PostWatchlistRequest?](Models/PostWatchlistRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Watchlist&gt; UpdateWatchlistByName(string name, PostWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default);</code></summary>

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
    var response = await client.Watchlists.UpdateWatchlistByName(name, body);
    // TODO: Handle 'response' of type Watchlist
}
catch (SdkException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Parameters

<dl>
<dd>

| Name | Type | Description |
| --- | --- | --- |
| <code>name</code> | <code>string</code> | name of the watchlist |
| <code>body</code> | <code>[PostWatchlistRequest?](Models/PostWatchlistRequest.cs)</code> | - |

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Watchlist](Models/Watchlist.cs)</code>

**OnError**: <code>[SdkException](Core/Exceptions/SdkException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

