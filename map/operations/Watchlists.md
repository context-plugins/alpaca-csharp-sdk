<!-- Generated file — do not edit; regenerated with the SDK. -->

# Watchlists — operations

Accessor: `client.Watchlists` · Source: `Api/Watchlists.cs` · 11 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AddAssetToWatchlist

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `AddAssetToWatchlist(Guid watchlistId, AddAssetToWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AddAssetToWatchlistRequest` | `Models/AddAssetToWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

### AddAssetToWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
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

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteWatchlistById(Guid watchlistId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### DeleteWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `DeleteWatchlistByName(string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `void` (Task)
- **Error**: `SdkException<RawError>` — **Case B**

### GetWatchlistById

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetWatchlistById(Guid watchlistId, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### GetWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetWatchlistByName(string name, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### GetWatchlists

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetWatchlists(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `IReadOnlyList<Watchlist>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### PostWatchlist

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `PostWatchlist(PostWatchlistRequest body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostWatchlistRequest` | `Models/PostWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

### RemoveAssetFromWatchlist

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `RemoveAssetFromWatchlist(Guid watchlistId, string symbol, RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Watchlist` | `Models/Watchlist.cs` |

### UpdateWatchlistById

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `UpdateWatchlistById(Guid watchlistId, PostWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostWatchlistRequest` | `Models/PostWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

### UpdateWatchlistByName

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `UpdateWatchlistByName(string name, PostWatchlistRequest? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `name` ← `name`
- **Returns**: `Watchlist`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PostWatchlistRequest` | `Models/PostWatchlistRequest.cs` |
| `Watchlist` | `Models/Watchlist.cs` |

