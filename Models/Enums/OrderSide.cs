using System.Text.Json.Serialization;
using TraderApi.Core.Enum;

namespace TraderApi.Models.Enums;

/// <summary>
/// Represents which side this order was on:
/// <list type="bullet">
///   <item><description>buy</description></item>
///   <item><description>sell</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderSide>))]
public sealed record OrderSide : StringEnum<OrderSide>
{
    private OrderSide(string value) : base(value)
    {
    }

    public static readonly OrderSide Buy = new("buy");

    public static readonly OrderSide Sell = new("sell");

    public static OrderSide FromValue(string value) => FromValueCore(value);
}
