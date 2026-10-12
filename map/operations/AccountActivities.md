<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountActivities — operations

Accessor: `client.AccountActivities` · Source: `src/Alpaca/Api/AccountActivities.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountActivities

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAccountActivities(GetAccountActivitiesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `date` ← `Date`, `until` ← `Until`, `after` ← `After`, `direction` ← `Direction`, `page_size` ← `PageSize`, `page_token` ← `PageToken`, `activity_types` ← `ActivityTypes`
- **Returns**: `IReadOnlyList<V2AccountActivitiesResponse>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAccountActivitiesRequest` | `src/Alpaca/Requests/AccountActivities/GetAccountActivitiesRequest.cs` |
| `Direction` | `src/Alpaca/Models/Enums/Direction.cs` |
| `V2AccountActivitiesResponse` | `src/Alpaca/Models/AnyOf/V2AccountActivitiesResponse.cs` |

### GetAccountActivitiesByActivityType

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAccountActivitiesByActivityType(GetAccountActivitiesByActivityTypeRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `ActivityType`
- **Query params (wire ← C#)**: `date` ← `Date`, `until` ← `Until`, `after` ← `After`, `direction` ← `Direction`, `page_size` ← `PageSize`, `page_token` ← `PageToken`
- **Returns**: `IReadOnlyList<V2AccountActivitiesResponse1>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetAccountActivitiesByActivityTypeRequest` | `src/Alpaca/Requests/AccountActivities/GetAccountActivitiesByActivityTypeRequest.cs` |
| `Direction` | `src/Alpaca/Models/Enums/Direction.cs` |
| `V2AccountActivitiesResponse1` | `src/Alpaca/Models/AnyOf/V2AccountActivitiesResponse1.cs` |

