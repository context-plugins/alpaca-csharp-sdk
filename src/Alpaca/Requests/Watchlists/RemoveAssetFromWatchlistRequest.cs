using System;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the RemoveAssetFromWatchlist operation.
/// </summary>
public sealed record RemoveAssetFromWatchlistRequest
{
    /// <summary>
    /// Watchlist ID
    /// </summary>
    public required Guid WatchlistId { get; init; }

    /// <summary>
    /// symbol name to remove from the watchlist content
    /// </summary>
    public required string Symbol { get; init; }
}
