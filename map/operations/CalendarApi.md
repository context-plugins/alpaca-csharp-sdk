<!-- Generated file — do not edit; regenerated with the SDK. -->

# CalendarApi — operations

Accessor: `client.CalendarApi` · Source: `Api/CalendarApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCalendar

- **Signature**: `GetCalendar(DateTimeOffset? start, DateTimeOffset? end, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `start` — nullable, no default → **must pass explicitly**
  - `end` — nullable, no default → **must pass explicitly**
- **Query params (wire ← C#)**: `start` ← `start`, `end` ← `end`
- **Returns**: `IReadOnlyList<Calendar>`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `Calendar` | `Models/Calendar.cs` |

