using System;
using Alpaca.Models.Enums;

namespace Alpaca.Requests.AccountActivities;

/// <summary>
/// The inputs of the GetAccountActivitiesByActivityType operation.
/// </summary>
public sealed record GetAccountActivitiesByActivityTypeRequest
{
    /// <summary>
    /// The activity type you want to view entries for. A list of valid activity types can be found at the bottom of this page.
    /// </summary>
    public required string ActivityType { get; init; }

    /// <summary>
    /// The date for which you want to see activities.
    /// </summary>
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// The response will contain only activities submitted before this date. (Cannot be used with date.)
    /// </summary>
    public DateTimeOffset? Until { get; init; }

    /// <summary>
    /// The response will contain only activities submitted after this date. (Cannot be used with date.)
    /// </summary>
    public DateTimeOffset? After { get; init; }

    /// <summary>
    /// asc or desc (default desc if unspecified.)
    /// </summary>
    public Direction? Direction { get; init; }

    /// <summary>
    /// The maximum number of entries to return in the response. (See the section on paging above.)
    /// </summary>
    public int? PageSize { get; init; }

    /// <summary>
    /// The ID of the end of your current page of results.
    /// </summary>
    public string? PageToken { get; init; }
}
