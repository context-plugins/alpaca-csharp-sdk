using System;
using Alpaca.Models;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the AddAssetToWatchlist operation.
/// </summary>
public sealed record AddAssetToWatchlistOperationRequest
{
    /// <summary>
    /// watchlist id
    /// </summary>
    public required Guid WatchlistId { get; init; }

    public AddAssetToWatchlistRequest? Body { get; init; }
}
