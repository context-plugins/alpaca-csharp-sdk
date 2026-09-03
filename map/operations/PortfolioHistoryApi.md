<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortfolioHistoryApi — operations

Accessor: `client.PortfolioHistoryApi` · Source: `Api/PortfolioHistoryApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountPortfolioHistory

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAccountPortfolioHistory(string? period, string? timeframe, DateTimeOffset? dateEnd, string? extendedHours, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 4 params (`period` … `extendedHours`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `period` ← `period`, `timeframe` ← `timeframe`, `date_end` ← `dateEnd`, `extended_hours` ← `extendedHours`
- **Returns**: `PortfolioHistory`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `PortfolioHistory` | `Models/PortfolioHistory.cs` |

