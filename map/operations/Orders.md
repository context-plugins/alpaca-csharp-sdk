<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `Api/Orders.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAllOrders

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteAllOrders(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<CanceledOrderResponse>`
- **Error**: `ApiException<DeleteAllOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CanceledOrderResponse` | `Models/CanceledOrderResponse.cs` |
| `DeleteAllOrdersError` | `Errors/DeleteAllOrdersError.cs` |

### DeleteOrderByOrderId

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteOrderByOrderId(DeleteOrderByOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeleteOrderByOrderIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrderByOrderIdRequest` | `Requests/Orders/DeleteOrderByOrderIdRequest.cs` |
| `DeleteOrderByOrderIdError` | `Errors/DeleteOrderByOrderIdError.cs` |

### GetAllOrders

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAllOrders(GetAllOrdersRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `status` ← `Status`, `limit` ← `Limit`, `after` ← `After`, `until` ← `Until`, `direction` ← `Direction`, `nested` ← `Nested`, `symbols` ← `Symbols`
- **Returns**: `IReadOnlyList<Order>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAllOrdersRequest` | `Requests/Orders/GetAllOrdersRequest.cs` |
| `Status1` | `Models/Enums/Status1.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `Order` | `Models/Order.cs` |

### GetOrderByOrderId

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetOrderByOrderId(GetOrderByOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`
- **Query params (wire ← C#)**: `nested` ← `Nested`
- **Returns**: `Order`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetOrderByOrderIdRequest` | `Requests/Orders/GetOrderByOrderIdRequest.cs` |
| `Order` | `Models/Order.cs` |

### PatchOrderByOrderId

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `PatchOrderByOrderId(PatchOrderByOrderIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `OrderId`, `Body`
- **Returns**: `Order`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PatchOrderByOrderIdRequest` | `Requests/Orders/PatchOrderByOrderIdRequest.cs` |
| `PatchOrderRequest` | `Models/PatchOrderRequest.cs` |
| `Order` | `Models/Order.cs` |

### PostOrder

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `PostOrder(PostOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `Order`
- **Error**: `ApiException<PostOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PostOrderRequest` | `Requests/Orders/PostOrderRequest.cs` |
| `Order` | `Models/Order.cs` |
| `PostOrderError` | `Errors/PostOrderError.cs` |

