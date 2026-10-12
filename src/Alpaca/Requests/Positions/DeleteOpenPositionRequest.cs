namespace Alpaca.Requests.Positions;

/// <summary>
/// The inputs of the DeleteOpenPosition operation.
/// </summary>
public sealed record DeleteOpenPositionRequest
{
    /// <summary>
    /// symbol or assetId
    /// </summary>
    public required string SymbolOrAssetId { get; init; }

    /// <summary>
    /// the number of shares to liquidate. Can accept up to 9 decimal points. Cannot work with percentage
    /// </summary>
    public double? Qty { get; init; }

    /// <summary>
    /// percentage of position to liquidate. Must be between 0 and 100. Would only sell fractional if position is originally fractional. Can accept up to 9 decimal points. Cannot work with qty
    /// </summary>
    public double? Percentage { get; init; }
}
