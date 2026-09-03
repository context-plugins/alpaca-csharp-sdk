<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountActivities — operations

Accessor: `client.AccountActivities` · Source: `Api/AccountActivities.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountActivities

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAccountActivities(DateTimeOffset? date, DateTimeOffset? until, DateTimeOffset? after, Direction? direction, int? pageSize, string? pageToken, string? activityTypes, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 7 params (`date` … `activityTypes`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `date` ← `date`, `until` ← `until`, `after` ← `after`, `direction` ← `direction`, `page_size` ← `pageSize`, `page_token` ← `pageToken`, `activity_types` ← `activityTypes`
- **Returns**: `IReadOnlyList<V2AccountActivitiesResponse>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `V2AccountActivitiesResponse` | `Models/AnyOf/V2AccountActivitiesResponse.cs` |

### GetAccountActivitiesByActivityType

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAccountActivitiesByActivityType(string activityType, DateTimeOffset? date, DateTimeOffset? until, DateTimeOffset? after, Direction? direction, int? pageSize, string? pageToken, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - 6 params (`date` … `pageToken`) — nullable, no default → **must pass explicitly** (pass `null` to skip)
- **Query params (wire ← C#)**: `date` ← `date`, `until` ← `until`, `after` ← `after`, `direction` ← `direction`, `page_size` ← `pageSize`, `page_token` ← `pageToken`
- **Returns**: `IReadOnlyList<V2AccountActivitiesResponse1>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Direction` | `Models/Enums/Direction.cs` |
| `V2AccountActivitiesResponse1` | `Models/AnyOf/V2AccountActivitiesResponse1.cs` |

