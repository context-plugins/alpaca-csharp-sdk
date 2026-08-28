using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Alpaca.Core;
using Alpaca.Core.ErrorResponse;
using Alpaca.Core.Exceptions;
using Alpaca.Core.Extensions;
using Alpaca.Core.Models;
using Alpaca.Core.Request;
using Alpaca.Core.Response;
using Alpaca.Models.AnyOf;
using Alpaca.Models.Enums;

namespace Alpaca.Api;

/// <summary>
/// Head to https://alpaca.markets/docs/api-references/trading-api/account-activities/ to view complete documentation on the Account Activities API.
/// </summary>
public sealed class AccountActivities
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal AccountActivities(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get account activities of one type
    /// </summary>
    /// <param name="date">The date for which you want to see activities.</param>
    /// <param name="until">The response will contain only activities submitted before this date. (Cannot be used with date.)</param>
    /// <param name="after">The response will contain only activities submitted after this date. (Cannot be used with date.)</param>
    /// <param name="direction">asc or desc (default desc if unspecified.)</param>
    /// <param name="pageSize">The maximum number of entries to return in the response. (See the section on paging above.)</param>
    /// <param name="pageToken">The ID of the end of your current page of results.</param>
    /// <param name="activityTypes">A comma-separated list of the activity types to include in the response. If unspecified, activities of all types will be returned. See ActivityType model for values</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V2AccountActivitiesResponse"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns account activity entries for many types of activities.
    /// </remarks>
    public Task<IReadOnlyList<V2AccountActivitiesResponse>> GetAccountActivities(DateTimeOffset? date,
        DateTimeOffset? until,
        DateTimeOffset? after,
        Direction? direction,
        int? pageSize,
        string? pageToken,
        string? activityTypes,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/account/activities"),
            [],
            [new Param("date", date?.ToIso8601()),
                new Param("until", until?.ToIso8601()),
                new Param("after", after?.ToIso8601()),
                new Param("direction", direction),
                new Param("page_size", pageSize),
                new Param("page_token", pageToken),
                new Param("activity_types", activityTypes)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V2AccountActivitiesResponse>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);

    /// <summary>
    /// Get account activities of one type
    /// </summary>
    /// <param name="activityType">The activity type you want to view entries for. A list of valid activity types can be found at the bottom of this page.</param>
    /// <param name="date">The date for which you want to see activities.</param>
    /// <param name="until">The response will contain only activities submitted before this date. (Cannot be used with date.)</param>
    /// <param name="after">The response will contain only activities submitted after this date. (Cannot be used with date.)</param>
    /// <param name="direction">asc or desc (default desc if unspecified.)</param>
    /// <param name="pageSize">The maximum number of entries to return in the response. (See the section on paging above.)</param>
    /// <param name="pageToken">The ID of the end of your current page of results.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V2AccountActivitiesResponse1"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns account activity entries for a specific type of activity.
    /// </remarks>
    public Task<IReadOnlyList<V2AccountActivitiesResponse1>> GetAccountActivitiesByActivityType(string activityType,
        DateTimeOffset? date,
        DateTimeOffset? until,
        DateTimeOffset? after,
        Direction? direction,
        int? pageSize,
        string? pageToken,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/account/activities/{activity_type}"),
            [new TemplateParam("activity_type", activityType)],
            [new Param("date", date?.ToIso8601()),
                new Param("until", until?.ToIso8601()),
                new Param("after", after?.ToIso8601()),
                new Param("direction", direction),
                new Param("page_size", pageSize),
                new Param("page_token", pageToken)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V2AccountActivitiesResponse1>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);
}
