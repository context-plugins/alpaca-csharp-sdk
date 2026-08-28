<!-- Generated file — do not edit; regenerated with the SDK. -->

# Watchlists — operations

Accessor: `client.Watchlists` · Source: `Api/Watchlists.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddAssetToWatchlist

- **Signature**: `AddAssetToWatchlist(Guid watchlistId, AddAssetToWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddAssetToWatchlistRequest` | `Models/AddAssetToWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

### AddAssetToWatchlistByName

- **Signature**: `AddAssetToWatchlistByName(string name, AddAssetToWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddAssetToWatchlistRequest` | `Models/AddAssetToWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

### DeleteWatchlistById

- **Signature**: `DeleteWatchlistById(Guid watchlistId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### DeleteWatchlistByName

- **Signature**: `DeleteWatchlistByName(string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetWatchlistById

- **Signature**: `GetWatchlistById(Guid watchlistId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### GetWatchlistByName

- **Signature**: `GetWatchlistByName(string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### GetWatchlists

- **Signature**: `GetWatchlists(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Watchlist>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### PostWatchlist

- **Signature**: `PostWatchlist(PostWatchlistRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostWatchlistRequest` | `Models/PostWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

### RemoveAssetFromWatchlist

- **Signature**: `RemoveAssetFromWatchlist(Guid watchlistId, string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### UpdateWatchlistById

- **Signature**: `UpdateWatchlistById(Guid watchlistId, PostWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostWatchlistRequest` | `Models/PostWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

### UpdateWatchlistByName

- **Signature**: `UpdateWatchlistByName(string name, PostWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostWatchlistRequest` | `Models/PostWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

