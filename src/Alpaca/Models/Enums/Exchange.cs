using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// Represents the current exchanges Alpaca supports. List is currently:
/// <list type="bullet">
///   <item><description>AMEX</description></item>
///   <item><description>ARCA</description></item>
///   <item><description>BATS</description></item>
///   <item><description>NYSE</description></item>
///   <item><description>NASDAQ</description></item>
///   <item><description>NYSEARCA</description></item>
///   <item><description>OTC</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Exchange>))]
public sealed record Exchange : OpenStringEnum<Exchange>
{
    private Exchange(string value) : base(value)
    {
    }

    public static readonly Exchange Amex = new("AMEX");

    public static readonly Exchange Arca = new("ARCA");

    public static readonly Exchange Bats = new("BATS");

    public static readonly Exchange Nyse = new("NYSE");

    public static readonly Exchange Nasdaq = new("NASDAQ");

    public static readonly Exchange Nysearca = new("NYSEARCA");

    public static readonly Exchange Otc = new("OTC");

    public TResult Match<TResult>(Func<TResult> onAmex,
        Func<TResult> onArca,
        Func<TResult> onBats,
        Func<TResult> onNyse,
        Func<TResult> onNasdaq,
        Func<TResult> onNysearca,
        Func<TResult> onOtc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Amex => onAmex(),
            _ when this == Arca => onArca(),
            _ when this == Bats => onBats(),
            _ when this == Nyse => onNyse(),
            _ when this == Nasdaq => onNasdaq(),
            _ when this == Nysearca => onNysearca(),
            _ when this == Otc => onOtc(),
            _ => otherwise(Value)
        };

    public void Match(Action onAmex,
        Action onArca,
        Action onBats,
        Action onNyse,
        Action onNasdaq,
        Action onNysearca,
        Action onOtc,
        Action<string> otherwise)
    {
        if (this == Amex) onAmex();
        else if (this == Arca) onArca();
        else if (this == Bats) onBats();
        else if (this == Nyse) onNyse();
        else if (this == Nasdaq) onNasdaq();
        else if (this == Nysearca) onNysearca();
        else if (this == Otc) onOtc();
        else otherwise(Value);
    }
}
