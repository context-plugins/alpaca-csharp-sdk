using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// fill or partial_fill
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Fill = new("fill");

    public static readonly TypeEnum PartialFill = new("partial_fill");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
