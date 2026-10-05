namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the DeleteWatchlistByName operation.
/// </summary>
public sealed record DeleteWatchlistByNameRequest
{
    /// <summary>
    /// name of the watchlist
    /// </summary>
    public required string Name { get; init; }
}
