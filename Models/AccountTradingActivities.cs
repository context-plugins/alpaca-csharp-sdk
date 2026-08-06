using System;
using System.Text.Json.Serialization;
using TraderApi.Models.Enums;

namespace TraderApi.Models;

public record AccountTradingActivities
{
    /// <summary>
    /// - FILL
    ///   Order fills (both partial and full fills)
    /// <para>
    /// - TRANS
    ///   Cash transactions (both CSD and CSW)
    /// </para>
    /// <para>
    /// - MISC
    ///   Miscellaneous or rarely used activity types (All types except those in TRANS, DIV, or FILL)
    /// </para>
    /// <para>
    /// - ACATC
    ///   ACATS IN/OUT (Cash)
    /// </para>
    /// <para>
    /// - ACATS
    ///   ACATS IN/OUT (Securities)
    /// </para>
    /// <para>
    /// - CFEE
    ///   Crypto fee
    /// </para>
    /// <para>
    /// - CSD
    ///   Cash deposit(+)
    /// </para>
    /// <para>
    /// - CSW
    ///   Cash withdrawal(-)
    /// </para>
    /// <para>
    /// - DIV
    ///   Dividends
    /// </para>
    /// <para>
    /// - DIVCGL
    ///   Dividend (capital gain long term)
    /// </para>
    /// <para>
    /// - DIVCGS
    ///   Dividend (capital gain short term)
    /// </para>
    /// <para>
    /// - DIVFEE
    ///   Dividend fee
    /// </para>
    /// <para>
    /// - DIVFT
    ///   Dividend adjusted (Foreign Tax Withheld)
    /// </para>
    /// <para>
    /// - DIVNRA
    ///   Dividend adjusted (NRA Withheld)
    /// </para>
    /// <para>
    /// - DIVROC
    ///   Dividend return of capital
    /// </para>
    /// <para>
    /// - DIVTW
    ///   Dividend adjusted (Tefra Withheld)
    /// </para>
    /// <para>
    /// - DIVTXEX
    ///   Dividend (tax exempt)
    /// </para>
    /// <para>
    /// - FEE
    ///   Fee denominated in USD
    /// </para>
    /// <para>
    /// - INT
    ///   Interest (credit/margin)
    /// </para>
    /// <para>
    /// - INTNRA
    ///   Interest adjusted (NRA Withheld)
    /// </para>
    /// <para>
    /// - INTTW
    ///   Interest adjusted (Tefra Withheld)
    /// </para>
    /// <para>
    /// - JNL
    ///   Journal entry
    /// </para>
    /// <para>
    /// - JNLC
    ///   Journal entry (cash)
    /// </para>
    /// <para>
    /// - JNLS
    ///   Journal entry (stock)
    /// </para>
    /// <para>
    /// - MA
    ///   Merger/Acquisition
    /// </para>
    /// <para>
    /// - NC
    ///   Name change
    /// </para>
    /// <para>
    /// - OPASN
    ///   Option assignment
    /// </para>
    /// <para>
    /// - OPEXP
    ///   Option expiration
    /// </para>
    /// <para>
    /// - OPXRC
    ///   Option exercise
    /// </para>
    /// <para>
    /// - PTC
    ///   Pass Thru Charge
    /// </para>
    /// <para>
    /// - PTR
    ///   Pass Thru Rebate
    /// </para>
    /// <para>
    /// - REORG
    ///   Reorg CA
    /// </para>
    /// <para>
    /// - SC
    ///   Symbol change
    /// </para>
    /// <para>
    /// - SSO
    ///   Stock spinoff
    /// </para>
    /// <para>
    /// - SSP
    ///   Stock split
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activity_type")]
    public ActivityType? ActivityType { get; init; }

    /// <summary>
    /// An id for the activity. Always in “::” format. Can be sent as page_token in requests to facilitate the paging of results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The cumulative quantity of shares involved in the execution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cum_qty")]
    public string? CumQty { get; init; }

    /// <summary>
    /// For partially_filled orders, the quantity of shares that are left to be filled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("leaves_qty")]
    public string? LeavesQty { get; init; }

    /// <summary>
    /// The per-share price that the trade was executed at.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public string? Price { get; init; }

    /// <summary>
    /// The number of shares involved in the trade execution.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qty")]
    public string? Qty { get; init; }

    /// <summary>
    /// buy or sell
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("side")]
    public string? Side { get; init; }

    /// <summary>
    /// The symbol of the security being traded.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("symbol")]
    public string? Symbol { get; init; }

    /// <summary>
    /// The time at which the execution occurred.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transaction_time")]
    public DateTimeOffset? TransactionTime { get; init; }

    /// <summary>
    /// The id for the order that filled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_id")]
    public Guid? OrderId { get; init; }

    /// <summary>
    /// fill or partial_fill
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; init; }

    /// <summary>
    /// An order executed through Alpaca can experience several status changes during its lifecycle. The most common statuses are described in detail below:
    /// <para>
    /// - new
    ///   The order has been received by Alpaca, and routed to exchanges for execution. This is the usual initial state of an order.
    /// </para>
    /// <para>
    /// - partially_filled
    ///   The order has been partially filled.
    /// </para>
    /// <para>
    /// - filled
    ///   The order has been filled, and no further updates will occur for the order.
    /// </para>
    /// <para>
    /// - done_for_day
    ///   The order is done executing for the day, and will not receive further updates until the next trading day.
    /// </para>
    /// <para>
    /// - canceled
    ///   The order has been canceled, and no further updates will occur for the order. This can be either due to a cancel request by the user, or the order has been canceled by the exchanges due to its time-in-force.
    /// </para>
    /// <para>
    /// - expired
    ///   The order has expired, and no further updates will occur for the order.
    /// </para>
    /// <para>
    /// - replaced
    ///   The order was replaced by another order, or was updated due to a market event such as corporate action.
    /// </para>
    /// <para>
    /// - pending_cancel
    ///   The order is waiting to be canceled.
    /// </para>
    /// <para>
    /// - pending_replace
    ///   The order is waiting to be replaced by another order. The order will reject cancel request while in this state.
    /// </para>
    /// <para>
    /// Less common states are described below. Note that these states only occur on very rare occasions, and most users will likely never see their orders reach these states:
    /// </para>
    /// <para>
    /// - accepted
    ///   The order has been received by Alpaca, but hasn’t yet been routed to the execution venue. This could be seen often out side of trading session hours.
    /// </para>
    /// <para>
    /// - pending_new
    ///   The order has been received by Alpaca, and routed to the exchanges, but has not yet been accepted for execution. This state only occurs on rare occasions.
    /// </para>
    /// <para>
    /// - accepted_for_bidding
    ///   The order has been received by exchanges, and is evaluated for pricing. This state only occurs on rare occasions.
    /// </para>
    /// <para>
    /// - stopped
    ///   The order has been stopped, and a trade is guaranteed for the order, usually at a stated price or better, but has not yet occurred. This state only occurs on rare occasions.
    /// </para>
    /// <para>
    /// - rejected
    ///   The order has been rejected, and no further updates will occur for the order. This state occurs on rare occasions and may occur based on various conditions decided by the exchanges.
    /// </para>
    /// <para>
    /// - suspended
    ///   The order has been suspended, and is not eligible for trading. This state only occurs on rare occasions.
    /// </para>
    /// <para>
    /// - calculated
    ///   The order has been completed for the day (either filled or done for day), but remaining settlement calculations are still pending. This state only occurs on rare occasions.
    /// </para>
    /// <para>
    ///
    /// An order may be canceled through the API up until the point it reaches a state of either filled, canceled, or expired.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("order_status")]
    public OrderStatus? OrderStatus { get; init; }
}
