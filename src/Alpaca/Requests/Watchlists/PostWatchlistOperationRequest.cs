using Alpaca.Models;

namespace Alpaca.Requests.Watchlists;

/// <summary>
/// The inputs of the PostWatchlist operation.
/// </summary>
public sealed record PostWatchlistOperationRequest
{
    public required PostWatchlistRequest Body { get; init; }
}
