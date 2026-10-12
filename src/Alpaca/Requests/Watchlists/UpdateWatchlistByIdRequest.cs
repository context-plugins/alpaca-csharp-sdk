using System;
using Alpaca.Models;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the UpdateWatchlistById operation.
/// </summary>
public sealed record UpdateWatchlistByIdRequest
{
    /// <summary>
    /// watchlist id
    /// </summary>
    public required Guid WatchlistId { get; init; }

    public PostWatchlistRequest? Body { get; init; }
}
