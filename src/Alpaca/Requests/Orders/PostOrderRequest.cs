using Alpaca.Models;

namespace Alpaca.Requests.Orders;

/// <summary>
/// The inputs of the PostOrder operation.
/// </summary>
public sealed record PostOrderRequest
{
    public required Order Body { get; init; }
}
