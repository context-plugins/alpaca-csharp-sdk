<!-- Generated file — do not edit; regenerated with the SDK. -->

# Positions — operations

Accessor: `client.Positions` · Source: `Api/Positions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAllOpenPositions

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteAllOpenPositions(bool? cancelOrders, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `cancelOrders` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `cancel_orders` ← `cancelOrders`
- **Returns**: `IReadOnlyList<PositionClosedReponse>`
- **Error**: `SdkException<DeleteAllOpenPositionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PositionClosedReponse` | `Models/PositionClosedReponse.cs` |
| `DeleteAllOpenPositionsError` | `Errors/DeleteAllOpenPositionsError.cs` |

### DeleteOpenPosition

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteOpenPosition(string symbolOrAssetId, double? qty, double? percentage, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `qty` — nullable, no default → **must pass explicitly**
  - `percentage` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `qty` ← `qty`, `percentage` ← `percentage`
- **Returns**: `Order`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Order` | `Models/Order.cs` |

### GetAllOpenPositions

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAllOpenPositions(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Position>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Position` | `Models/Position.cs` |

### GetOpenPosition

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetOpenPosition(string symbolOrAssetId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Position`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Position` | `Models/Position.cs` |

