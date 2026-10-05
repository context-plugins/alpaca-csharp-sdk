using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// This will either be the empty string "", "simple", "bracket", "oco", or "oto".
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderClass>))]
public sealed record OrderClass : OpenStringEnum<OrderClass>
{
    private OrderClass(string value) : base(value)
    {
    }

    public static readonly OrderClass Simple = new("simple");

    public static readonly OrderClass Bracket = new("bracket");

    public static readonly OrderClass Oco = new("oco");

    public static readonly OrderClass Oto = new("oto");

    public TResult Match<TResult>(Func<TResult> onSimple,
        Func<TResult> onBracket,
        Func<TResult> onOco,
        Func<TResult> onOto,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Simple => onSimple(),
            _ when this == Bracket => onBracket(),
            _ when this == Oco => onOco(),
            _ when this == Oto => onOto(),
            _ => otherwise(Value)
        };

    public void Match(Action onSimple, Action onBracket, Action onOco, Action onOto, Action<string> otherwise)
    {
        if (this == Simple) onSimple();
        else if (this == Bracket) onBracket();
        else if (this == Oco) onOco();
        else if (this == Oto) onOto();
        else otherwise(Value);
    }
}
