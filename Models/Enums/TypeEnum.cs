using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// fill or partial_fill
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : OpenStringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Fill = new("fill");

    public static readonly TypeEnum PartialFill = new("partial_fill");

    public TResult Match<TResult>(Func<TResult> onFill, Func<TResult> onPartialFill, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Fill => onFill(),
            _ when this == PartialFill => onPartialFill(),
            _ => otherwise(Value)
        };

    public void Match(Action onFill, Action onPartialFill, Action<string> otherwise)
    {
        if (this == Fill) onFill();
        else if (this == PartialFill) onPartialFill();
        else otherwise(Value);
    }
}
