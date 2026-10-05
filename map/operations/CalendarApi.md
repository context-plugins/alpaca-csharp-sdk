<!-- Generated file — do not edit; regenerated with the SDK. -->

# CalendarApi — operations

Accessor: `client.CalendarApi` · Source: `Api/CalendarApi.cs` · 1 operation

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetCalendar

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetCalendar(GetCalendarRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `start` ← `Start`, `end` ← `End`
- **Returns**: `IReadOnlyList<Calendar>`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `GetCalendarRequest` | `Requests/CalendarApi/GetCalendarRequest.cs` |
| `Calendar` | `Models/Calendar.cs` |

