using System;

namespace Alpaca.Requests.CalendarApi;

/// <summary>
/// The inputs of the GetCalendar operation.
/// </summary>
public sealed record GetCalendarRequest
{
    /// <summary>
    /// The first date to retrieve data for (inclusive)
    /// </summary>
    public DateTimeOffset? Start { get; init; }

    /// <summary>
    /// The last date to retrieve data for (inclusive)
    /// </summary>
    public DateTimeOffset? End { get; init; }
}
