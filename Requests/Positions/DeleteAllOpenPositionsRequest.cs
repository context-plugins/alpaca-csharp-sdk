namespace Alpaca.Requests.Positions;

/// <summary>
/// The inputs of the DeleteAllOpenPositions operation.
/// </summary>
public sealed record DeleteAllOpenPositionsRequest
{
    /// <summary>
    /// If true is specified, cancel all open orders before liquidating all positions.
    /// </summary>
    public bool? CancelOrders { get; init; }
}
