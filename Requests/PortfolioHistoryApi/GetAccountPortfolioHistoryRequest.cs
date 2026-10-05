using System;

namespace Alpaca.Requests.PortfolioHistoryApi;

/// <summary>
/// The inputs of the GetAccountPortfolioHistory operation.
/// </summary>
public sealed record GetAccountPortfolioHistoryRequest
{
    /// <summary>
    /// The duration of the data in &lt;number&gt; + &lt;unit&gt;, such as 1D, where &lt;unit&gt; can be D for day, W for week, M for month and A for year. Defaults to 1M.
    /// </summary>
    public string? Period { get; init; }

    /// <summary>
    /// The resolution of time window. 1Min, 5Min, 15Min, 1H, or 1D. If omitted, 1Min for less than 7 days period, 15Min for less than 30 days, or otherwise 1D.
    /// </summary>
    public string? Timeframe { get; init; }

    /// <summary>
    /// The date the data is returned up to, in “YYYY-MM-DD” format. Defaults to the current market date (rolls over at the market open if extended_hours is false, otherwise at 7am ET)
    /// </summary>
    public DateTimeOffset? DateEnd { get; init; }

    /// <summary>
    /// If true, include extended hours in the result. This is effective only for timeframe less than 1D.
    /// </summary>
    public string? ExtendedHours { get; init; }
}
