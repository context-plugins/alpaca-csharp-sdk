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
using Alpaca.Requests.AccountActivities;

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
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V2AccountActivitiesResponse"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns account activity entries for many types of activities.
    /// </remarks>
    public Task<IReadOnlyList<V2AccountActivitiesResponse>> GetAccountActivities(GetAccountActivitiesRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/account/activities"),
            [],
            [
                new Param("date", request.Date?.ToIso8601()),
                new Param("until", request.Until?.ToIso8601()),
                new Param("after", request.After?.ToIso8601()),
                new Param("direction", request.Direction),
                new Param("page_size", request.PageSize),
                new Param("page_token", request.PageToken),
                new Param("activity_types", request.ActivityTypes),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V2AccountActivitiesResponse>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            cancellationToken);

    /// <summary>
    /// Get account activities of one type
    /// </summary>
    /// <param name="request">The operation's inputs</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="V2AccountActivitiesResponse1"/> instance.</returns>
    /// <exception cref="ApiException{TError}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns account activity entries for a specific type of activity.
    /// </remarks>
    public Task<IReadOnlyList<V2AccountActivitiesResponse1>> GetAccountActivitiesByActivityType(GetAccountActivitiesByActivityTypeRequest request,
        RequestOptions? requestOptions = null,
        CancellationToken cancellationToken = default) =>
        _rawClient.Execute(
            _server.Default("/v2/account/activities/{activity_type}"),
            [new TemplateParam("activity_type", request.ActivityType)],
            [
                new Param("date", request.Date?.ToIso8601()),
                new Param("until", request.Until?.ToIso8601()),
                new Param("after", request.After?.ToIso8601()),
                new Param("direction", request.Direction),
                new Param("page_size", request.PageSize),
                new Param("page_token", request.PageToken),
            ],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<V2AccountActivitiesResponse1>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            cancellationToken);
}
