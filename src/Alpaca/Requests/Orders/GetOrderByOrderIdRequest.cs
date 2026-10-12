using System;

namespace Alpaca.Requests.Orders;

/// <summary>
/// The inputs of the GetOrderByOrderId operation.
/// </summary>
public sealed record GetOrderByOrderIdRequest
{
    /// <summary>
    /// order id
    /// </summary>
    public required Guid OrderId { get; init; }

    /// <summary>
    /// If true, the result will roll up multi-leg orders under the legs field of primary order.
    /// </summary>
    public bool? Nested { get; init; }
}
