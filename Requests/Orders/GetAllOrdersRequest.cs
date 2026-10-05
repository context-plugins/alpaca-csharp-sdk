using Alpaca.Models.Enums;

namespace Alpaca.Requests.Orders;

/// <summary>
/// The inputs of the GetAllOrders operation.
/// </summary>
public sealed record GetAllOrdersRequest
{
    /// <summary>
    /// Order status to be queried. open, closed or all. Defaults to open.
    /// </summary>
    public Status1? Status { get; init; }

    /// <summary>
    /// The maximum number of orders in response. Defaults to 50 and max is 500.
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// The response will include only ones submitted after this timestamp (exclusive.)
    /// </summary>
    public string? After { get; init; }

    /// <summary>
    /// The response will include only ones submitted until this timestamp (exclusive.)
    /// </summary>
    public string? Until { get; init; }

    /// <summary>
    /// The chronological order of response based on the submission time. asc or desc. Defaults to desc.
    /// </summary>
    public Direction? Direction { get; init; }

    /// <summary>
    /// If true, the result will roll up multi-leg orders under the legs field of primary order.
    /// </summary>
    public bool? Nested { get; init; }

    /// <summary>
    /// A comma-separated list of symbols to filter by (ex. “AAPL,TSLA,MSFT”). A currency pair is required for crypto orders (ex. “BTCUSD,BCHUSD,LTCUSD,ETCUSD”).
    /// </summary>
    public string? Symbols { get; init; }
}
