using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<TimeInForce>))]
public sealed record TimeInForce : OpenStringEnum<TimeInForce>
{
    private TimeInForce(string value) : base(value)
    {
    }

    public static readonly TimeInForce Day = new("day");

    public static readonly TimeInForce Gtc = new("gtc");

    public static readonly TimeInForce Opg = new("opg");

    public static readonly TimeInForce Cls = new("cls");

    public static readonly TimeInForce Ioc = new("ioc");

    public static readonly TimeInForce Fok = new("fok");

    public TResult Match<TResult>(Func<TResult> onDay,
        Func<TResult> onGtc,
        Func<TResult> onOpg,
        Func<TResult> onCls,
        Func<TResult> onIoc,
        Func<TResult> onFok,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Day => onDay(),
            _ when this == Gtc => onGtc(),
            _ when this == Opg => onOpg(),
            _ when this == Cls => onCls(),
            _ when this == Ioc => onIoc(),
            _ when this == Fok => onFok(),
            _ => otherwise(Value)
        };

    public void Match(Action onDay,
        Action onGtc,
        Action onOpg,
        Action onCls,
        Action onIoc,
        Action onFok,
        Action<string> otherwise)
    {
        if (this == Day) onDay();
        else if (this == Gtc) onGtc();
        else if (this == Opg) onOpg();
        else if (this == Cls) onCls();
        else if (this == Ioc) onIoc();
        else if (this == Fok) onFok();
        else otherwise(Value);
    }
}
