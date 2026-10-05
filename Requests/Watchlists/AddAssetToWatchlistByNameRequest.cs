using Alpaca.Models;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the AddAssetToWatchlistByName operation.
/// </summary>
public sealed record AddAssetToWatchlistByNameRequest
{
    /// <summary>
    /// name of the watchlist
    /// </summary>
    public required string Name { get; init; }

    public AddAssetToWatchlistRequest? Body { get; init; }
}
