using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// both, entry, or exit. Controls Day Trading Margin Call (DTMC) checks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DtbpCheck>))]
public sealed record DtbpCheck : OpenStringEnum<DtbpCheck>
{
    private DtbpCheck(string value) : base(value)
    {
    }

    public static readonly DtbpCheck Both = new("both");

    public static readonly DtbpCheck Entry = new("entry");

    public static readonly DtbpCheck Exit = new("exit");

    public TResult Match<TResult>(Func<TResult> onBoth,
        Func<TResult> onEntry,
        Func<TResult> onExit,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Both => onBoth(),
            _ when this == Entry => onEntry(),
            _ when this == Exit => onExit(),
            _ => otherwise(Value)
        };

    public void Match(Action onBoth, Action onEntry, Action onExit, Action<string> otherwise)
    {
        if (this == Both) onBoth();
        else if (this == Entry) onEntry();
        else if (this == Exit) onExit();
        else otherwise(Value);
    }
}
