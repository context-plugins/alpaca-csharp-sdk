<!-- Generated file — do not edit; regenerated with the SDK. -->

# Watchlists — operations

Accessor: `client.Watchlists` · Source: `src/Alpaca/Api/Watchlists.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddAssetToWatchlist

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `AddAssetToWatchlist(AddAssetToWatchlistOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WatchlistId`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddAssetToWatchlistOperationRequest` | `src/Alpaca/Requests/Watchlists/AddAssetToWatchlistOperationRequest.cs` |
| `AddAssetToWatchlistRequest` | `src/Alpaca/Models/AddAssetToWatchlistRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### AddAssetToWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `AddAssetToWatchlistByName(AddAssetToWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddAssetToWatchlistByNameRequest` | `src/Alpaca/Requests/Watchlists/AddAssetToWatchlistByNameRequest.cs` |
| `AddAssetToWatchlistRequest` | `src/Alpaca/Models/AddAssetToWatchlistRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### DeleteWatchlistById

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteWatchlistById(DeleteWatchlistByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WatchlistId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteWatchlistByIdRequest` | `src/Alpaca/Requests/Watchlists/DeleteWatchlistByIdRequest.cs` |

### DeleteWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteWatchlistByName(DeleteWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `void` (Task)
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `DeleteWatchlistByNameRequest` | `src/Alpaca/Requests/Watchlists/DeleteWatchlistByNameRequest.cs` |

### GetWatchlistById

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetWatchlistById(GetWatchlistByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WatchlistId`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetWatchlistByIdRequest` | `src/Alpaca/Requests/Watchlists/GetWatchlistByIdRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### GetWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetWatchlistByName(GetWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetWatchlistByNameRequest` | `src/Alpaca/Requests/Watchlists/GetWatchlistByNameRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### GetWatchlists

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetWatchlists(RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `IReadOnlyList<Watchlist>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### PostWatchlist

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `PostWatchlist(PostWatchlistOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostWatchlistOperationRequest` | `src/Alpaca/Requests/Watchlists/PostWatchlistOperationRequest.cs` |
| `PostWatchlistRequest` | `src/Alpaca/Models/PostWatchlistRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### RemoveAssetFromWatchlist

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `RemoveAssetFromWatchlist(RemoveAssetFromWatchlistRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WatchlistId`, `Symbol`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `RemoveAssetFromWatchlistRequest` | `src/Alpaca/Requests/Watchlists/RemoveAssetFromWatchlistRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### UpdateWatchlistById

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `UpdateWatchlistById(UpdateWatchlistByIdRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `WatchlistId`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWatchlistByIdRequest` | `src/Alpaca/Requests/Watchlists/UpdateWatchlistByIdRequest.cs` |
| `PostWatchlistRequest` | `src/Alpaca/Models/PostWatchlistRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

### UpdateWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `UpdateWatchlistByName(UpdateWatchlistByNameRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Name`
- **Query params (wire ← C#)**: `name` ← `Name`
- **Returns**: `Watchlist`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `UpdateWatchlistByNameRequest` | `src/Alpaca/Requests/Watchlists/UpdateWatchlistByNameRequest.cs` |
| `PostWatchlistRequest` | `src/Alpaca/Models/PostWatchlistRequest.cs` |
| `Watchlist` | `src/Alpaca/Models/Watchlist.cs` |

