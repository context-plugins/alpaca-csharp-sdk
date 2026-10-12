using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// Represents which side this order was on:
/// <list type="bullet">
///   <item><description>buy</description></item>
///   <item><description>sell</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderSide>))]
public sealed record OrderSide : OpenStringEnum<OrderSide>
{
    private OrderSide(string value) : base(value)
    {
    }

    public static readonly OrderSide Buy = new("buy");

    public static readonly OrderSide Sell = new("sell");

    public TResult Match<TResult>(Func<TResult> onBuy, Func<TResult> onSell, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Buy => onBuy(),
            _ when this == Sell => onSell(),
            _ => otherwise(Value)
        };

    public void Match(Action onBuy, Action onSell, Action<string> otherwise)
    {
        if (this == Buy) onBuy();
        else if (this == Sell) onSell();
        else otherwise(Value);
    }
}
