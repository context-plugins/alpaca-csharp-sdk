namespace Alpaca.Requests.Positions;

/// <summary>
/// The inputs of the GetOpenPosition operation.
/// </summary>
public sealed record GetOpenPositionRequest
{
    /// <summary>
    /// symbol or assetId
    /// </summary>
    public required string SymbolOrAssetId { get; init; }
}
