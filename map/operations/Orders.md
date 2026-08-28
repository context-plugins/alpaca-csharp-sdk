<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `Api/Orders.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAllOrders

- **Signature**: `DeleteAllOrders(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<CanceledOrderResponse>`
- **Error**: `SdkException<DeleteAllOrdersError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CanceledOrderResponse` | `Models/CanceledOrderResponse.cs` |
| `DeleteAllOrdersError` | `Errors/DeleteAllOrdersError.cs` |

### DeleteOrderByOrderId

- **Signature**: `DeleteOrderByOrderId(Guid orderId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<DeleteOrderByOrderIdError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteOrderByOrderIdError` | `Errors/DeleteOrderByOrderIdError.cs` |

### GetAllOrders

- **Signature**: `GetAllOrders(Status1? status, int? limit, string? after, string? until, Direction? direction, bool? nested, string? symbols, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`status` … `symbols`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `status` ← `status`, `limit` ← `limit`, `after` ← `after`, `until` ← `until`, `direction` ← `direction`, `nested` ← `nested`, `symbols` ← `symbols`
- **Returns**: `IReadOnlyList<Order>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Status1` | `Models/Enums/Status1.cs` |
| `Direction` | `Models/Enums/Direction.cs` |
| `Order` | `Models/Order.cs` |

### GetOrderByOrderId

- **Signature**: `GetOrderByOrderId(Guid orderId, bool? nested, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `nested` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `nested` ← `nested`
- **Returns**: `Order`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order` | `Models/Order.cs` |

### PatchOrderByOrderId

- **Signature**: `PatchOrderByOrderId(Guid orderId, PatchOrderRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Order`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PatchOrderRequest` | `Models/PatchOrderRequest.cs` |
| `Order` | `Models/Order.cs` |

### PostOrder

- **Signature**: `PostOrder(Order body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Order`
- **Error**: `SdkException<PostOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [403, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `Order` | `Models/Order.cs` |
| `PostOrderError` | `Errors/PostOrderError.cs` |

