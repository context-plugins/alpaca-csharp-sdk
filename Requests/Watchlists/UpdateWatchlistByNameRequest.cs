using Alpaca.Models;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the UpdateWatchlistByName operation.
/// </summary>
public sealed record UpdateWatchlistByNameRequest
{
    /// <summary>
    /// name of the watchlist
    /// </summary>
    public required string Name { get; init; }

    public PostWatchlistRequest? Body { get; init; }
}
