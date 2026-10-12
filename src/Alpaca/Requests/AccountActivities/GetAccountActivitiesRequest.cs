using System;
using Alpaca.Models.Enums;

namespace Alpaca.Requests.AccountActivities;

/// <summary>
/// The inputs of the GetAccountActivities operation.
/// </summary>
public sealed record GetAccountActivitiesRequest
{
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

    /// <summary>
    /// A comma-separated list of the activity types to include in the response. If unspecified, activities of all types will be returned. See ActivityType model for values
    /// </summary>
    public string? ActivityTypes { get; init; }
}
