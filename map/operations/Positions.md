<!-- Generated file — do not edit; regenerated with the SDK. -->

# Positions — operations

Accessor: `client.Positions` · Source: `Api/Positions.cs` · 4 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### DeleteAllOpenPositions

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteAllOpenPositions(DeleteAllOpenPositionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `cancel_orders` ← `CancelOrders`
- **Returns**: `IReadOnlyList<PositionClosedReponse>`
- **Error**: `ApiException<DeleteAllOpenPositionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeleteAllOpenPositionsRequest` | `Requests/Positions/DeleteAllOpenPositionsRequest.cs` |
| `PositionClosedReponse` | `Models/PositionClosedReponse.cs` |
| `DeleteAllOpenPositionsError` | `Errors/DeleteAllOpenPositionsError.cs` |

### DeleteOpenPosition

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteOpenPosition(DeleteOpenPositionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SymbolOrAssetId`
- **Query params (wire ← C#)**: `qty` ← `Qty`, `percentage` ← `Percentage`
- **Returns**: `Order`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteOpenPositionRequest` | `Requests/Positions/DeleteOpenPositionRequest.cs` |
| `Order` | `Models/Order.cs` |

### GetAllOpenPositions

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAllOpenPositions(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<Position>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Position` | `Models/Position.cs` |

### GetOpenPosition

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetOpenPosition(GetOpenPositionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `SymbolOrAssetId`
- **Returns**: `Position`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetOpenPositionRequest` | `Requests/Positions/GetOpenPositionRequest.cs` |
| `Position` | `Models/Position.cs` |

