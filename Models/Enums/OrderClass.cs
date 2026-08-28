using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// This will either be the empty string "", "simple", "bracket", "oco", or "oto".
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderClass>))]
public sealed record OrderClass : StringEnum<OrderClass>
{
    private OrderClass(string value) : base(value)
    {
    }

    public static readonly OrderClass Simple = new("simple");

    public static readonly OrderClass Bracket = new("bracket");

    public static readonly OrderClass Oco = new("oco");

    public static readonly OrderClass Oto = new("oto");

    public static OrderClass FromValue(string value) => FromValueCore(value);
}
