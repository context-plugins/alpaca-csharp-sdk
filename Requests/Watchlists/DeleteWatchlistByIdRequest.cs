using System;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the DeleteWatchlistById operation.
/// </summary>
public sealed record DeleteWatchlistByIdRequest
{
    /// <summary>
    /// watchlist id
    /// </summary>
    public required Guid WatchlistId { get; init; }
}
