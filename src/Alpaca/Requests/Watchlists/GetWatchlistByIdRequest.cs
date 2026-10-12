using System;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the GetWatchlistById operation.
/// </summary>
public sealed record GetWatchlistByIdRequest
{
    /// <summary>
    /// watchlist id
    /// </summary>
    public required Guid WatchlistId { get; init; }
}
