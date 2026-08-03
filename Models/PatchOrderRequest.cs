using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TraderApi.Models.Enums;

namespace TraderApi.Models;

/// <summary>
/// Represents a request to patch an order.
/// </summary>
public record PatchOrderRequest
{
    /// <summary>
    /// number of shares to trade
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qty")]
    public string? Qty { get; init; }

    /// <summary>
    /// Note: For Crypto Trading, Alpaca supports the following Time-In-Force designations: day, gtc, ioc and fok. OPG and CLS are not supported.
    /// <para>
    /// Alpaca supports the following Time-In-Force designations:
    /// </para>
    /// <para>
    /// - day
    ///   A day order is eligible for execution only on the day it is live. By default, the order is only valid during Regular Trading Hours (9:30am - 4:00pm ET). If unfilled after the closing auction, it is automatically canceled. If submitted after the close, it is queued and submitted the following trading day. However, if marked as eligible for extended hours, the order can also execute during supported extended hours.
    /// </para>
    /// <para>
    /// - gtc
    ///   The order is good until canceled. Non-marketable GTC limit orders are subject to price adjustments to offset corporate actions affecting the issue. We do not currently support Do Not Reduce(DNR) orders to opt out of such price adjustments.
    /// </para>
    /// <para>
    /// - opg
    ///   Use this TIF with a market/limit order type to submit “market on open” (MOO) and “limit on open” (LOO) orders. This order is eligible to execute only in the market opening auction. Any unfilled orders after the open will be cancelled. OPG orders submitted after 9:28am but before 7:00pm ET will be rejected. OPG orders submitted after 7:00pm will be queued and routed to the following day’s opening auction. On open/on close orders are routed to the primary exchange. Such orders do not necessarily execute exactly at 9:30am / 4:00pm ET but execute per the exchange’s auction rules.
    /// </para>
    /// <para>
    /// - cls
    ///   Use this TIF with a market/limit order type to submit “market on close” (MOC) and “limit on close” (LOC) orders. This order is eligible to execute only in the market closing auction. Any unfilled orders after the close will be cancelled. CLS orders submitted after 3:50pm but before 7:00pm ET will be rejected. CLS orders submitted after 7:00pm will be queued and routed to the following day’s closing auction. Only available with API v2.
    /// </para>
    /// <para>
    /// - ioc
    ///   An Immediate Or Cancel (IOC) order requires all or part of the order to be executed immediately. Any unfilled portion of the order is canceled. Only available with API v2. Most market makers who receive IOC orders will attempt to fill the order on a principal basis only, and cancel any unfilled balance. On occasion, this can result in the entire order being cancelled if the market maker does not have any existing inventory of the security in question.
    /// </para>
    /// <para>
    /// - fok
    ///   A Fill or Kill (FOK) order is only executed if the entire order quantity can be filled, otherwise the order is canceled. Only available with API v2.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_in_force")]
    public TimeInForce? TimeInForce { get; init; }

    /// <summary>
    /// required if original order type is limit or stop_limit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit_price")]
    public string? LimitPrice { get; init; }

    /// <summary>
    /// required if original order type is limit or stop_limit
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stop_price")]
    public string? StopPrice { get; init; }

    /// <summary>
    /// the new value of the trail_price or trail_percent value (works only for type=“trailing_stop”)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trail")]
    public string? Trail { get; init; }

    /// <summary>
    /// A unique identifier for the order. Automatically generated if not sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("client_order_id")]
    [MaxLength(48)]
    public string? ClientOrderId { get; init; }
}
