using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TraderApi.Core;
using TraderApi.Core.ErrorResponse;
using TraderApi.Core.Exceptions;
using TraderApi.Core.Extensions;
using TraderApi.Core.Models;
using TraderApi.Core.Request;
using TraderApi.Core.Response;
using TraderApi.Models;

namespace TraderApi.Api;

/// <summary>
/// Head to https://alpaca.markets/docs/api-documentation/api-v2/portfolio-history/ to view complete documentation on the Portfolio History API.
/// </summary>
public sealed class PortfolioHistoryApi
{
    private readonly RawClient _rawClient;
    private readonly Server _server;
    private readonly AuthSchemes _auth;

    internal PortfolioHistoryApi(RawClient rawClient, Server server, AuthSchemes auth)
    {
        _rawClient = rawClient;
        _server = server;
        _auth = auth;
    }

    /// <summary>
    /// Account Portfolio History
    /// </summary>
    /// <param name="period">The duration of the data in &lt;number&gt; + &lt;unit&gt;, such as 1D, where &lt;unit&gt; can be D for day, W for week, M for month and A for year. Defaults to 1M.</param>
    /// <param name="timeframe">The resolution of time window. 1Min, 5Min, 15Min, 1H, or 1D. If omitted, 1Min for less than 7 days period, 15Min for less than 30 days, or otherwise 1D.</param>
    /// <param name="dateEnd">The date the data is returned up to, in “YYYY-MM-DD” format. Defaults to the current market date (rolls over at the market open if extended_hours is false, otherwise at 7am ET)</param>
    /// <param name="extendedHours">If true, include extended hours in the result. This is effective only for timeframe less than 1D.</param>
    /// <param name="requestOptions">Per-request options, such as an overriding log level for this call</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>A <see cref="Task{TResult}"/> of <see cref="PortfolioHistory"/> instance.</returns>
    /// <exception cref="SdkException{TResult}"> of <see cref="RawError"/> when the server returns an error response.</exception>
    /// <remarks>
    /// Returns timeseries data about equity and profit/loss (P/L) of the account in requested timespan.
    /// </remarks>
    public Task<PortfolioHistory> GetAccountPortfolioHistory(string? period,
        string? timeframe,
        DateTimeOffset? dateEnd,
        string? extendedHours,
        RequestOptions? requestOptions = null,
        CancellationToken ct = default) =>
        _rawClient.Execute(_server.Default("/v2/account/portfolio/history"),
            [],
            [new Param("period", period),
                new Param("timeframe", timeframe),
                new Param("date_end", dateEnd?.ToDate()),
                new Param("extended_hours", extendedHours)],
            [],
            HttpMethod.Get,
            EmptyBody.Instance,
            JsonResponse.Create<PortfolioHistory>(),
            RawErrorResponse.Instance,
            [_auth.ApiKey, _auth.ApiSecret],
            requestOptions,
            ct);
}
