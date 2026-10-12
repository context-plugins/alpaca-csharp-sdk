namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the GetWatchlistByName operation.
/// </summary>
public sealed record GetWatchlistByNameRequest
{
    /// <summary>
    /// name of the watchlist
    /// </summary>
    public required string Name { get; init; }
}
