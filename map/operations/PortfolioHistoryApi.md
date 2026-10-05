<!-- Generated file — do not edit; regenerated with the SDK. -->

# PortfolioHistoryApi — operations

Accessor: `client.PortfolioHistoryApi` · Source: `Api/PortfolioHistoryApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountPortfolioHistory

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAccountPortfolioHistory(GetAccountPortfolioHistoryRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `period` ← `Period`, `timeframe` ← `Timeframe`, `date_end` ← `DateEnd`, `extended_hours` ← `ExtendedHours`
- **Returns**: `PortfolioHistory`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAccountPortfolioHistoryRequest` | `Requests/PortfolioHistoryApi/GetAccountPortfolioHistoryRequest.cs` |
| `PortfolioHistory` | `Models/PortfolioHistory.cs` |

