using System;

namespace Alpaca.Requests.Orders;

/// <summary>
/// The inputs of the DeleteOrderByOrderId operation.
/// </summary>
public sealed record DeleteOrderByOrderIdRequest
{
    /// <summary>
    /// order id
    /// </summary>
    public required Guid OrderId { get; init; }
}
