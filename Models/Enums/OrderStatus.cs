using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<OrderStatus>))]
public sealed record OrderStatus : StringEnum<OrderStatus>
{
    private OrderStatus(string value) : base(value)
    {
    }

    public static readonly OrderStatus New = new("new");

    public static readonly OrderStatus PartiallyFilled = new("partially_filled");

    public static readonly OrderStatus Filled = new("filled");

    public static readonly OrderStatus DoneForDay = new("done_for_day");

    public static readonly OrderStatus Canceled = new("canceled");

    public static readonly OrderStatus Expired = new("expired");

    public static readonly OrderStatus Replaced = new("replaced");

    public static readonly OrderStatus PendingCancel = new("pending_cancel");

    public static readonly OrderStatus PendingReplace = new("pending_replace");

    public static readonly OrderStatus Accepted = new("accepted");

    public static readonly OrderStatus PendingNew = new("pending_new");

    public static readonly OrderStatus AcceptedForBidding = new("accepted_for_bidding");

    public static readonly OrderStatus Stopped = new("stopped");

    public static readonly OrderStatus Rejected = new("rejected");

    public static readonly OrderStatus Suspended = new("suspended");

    public static readonly OrderStatus Calculated = new("calculated");

    public static OrderStatus FromValue(string value) => FromValueCore(value);
}
