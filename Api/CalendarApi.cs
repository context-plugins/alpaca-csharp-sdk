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
using Alpaca.Models;

namespace Alpaca.Api;

/// <summary>
/// Head to https://alpaca.markets/docs/api-references/trading-api/calendar/ to view complete documentation on the Market Calendar API.
/// </summary>
public sealed class CalendarApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal CalendarApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Get Market Calendar info
    /// </summary>
    /// <param name="start">The first date to retrieve data for (inclusive)</param>
    /// <param name="end">The last date to retrieve data for (inclusive)</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="IReadOnlyList{T}"/> of <see cref="Calendar"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns the market calendar.
    /// </remarks>
    public Task<IReadOnlyList<Calendar>> GetCalendar(DateTimeOffset? start,
        DateTimeOffset? end,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/calendar"),
            [],
            [new Param("start", start?.ToIso8601()), new Param("end", end?.ToIso8601())],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<IReadOnlyList<Calendar>>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);
}
