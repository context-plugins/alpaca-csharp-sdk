using System;
using Alpaca.Models;

namespace Alpaca.Requests.Orders;

/// <summary>
/// The inputs of the PatchOrderByOrderId operation.
/// </summary>
public sealed record PatchOrderByOrderIdRequest
{
    /// <summary>
    /// order id
    /// </summary>
    public required Guid OrderId { get; init; }

    public required PatchOrderRequest Body { get; init; }
}
