using System.Text.Json.Serialization;
using TraderApi.Core.Enum;

namespace TraderApi.Models.Enums;

/// <summary>
/// Represents the types of orders Alpaca currently supports
/// <list type="bullet">
///   <item><description>market</description></item>
///   <item><description>limit</description></item>
///   <item><description>stop</description></item>
///   <item><description>stop_limit</description></item>
///   <item><description>trailing_stop</description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OrderType>))]
public sealed record OrderType : StringEnum<OrderType>
{
    private OrderType(string value) : base(value)
    {
    }

    public static readonly OrderType Market = new("market");

    public static readonly OrderType Limit = new("limit");

    public static readonly OrderType Stop = new("stop");

    public static readonly OrderType StopLimit = new("stop_limit");

    public static readonly OrderType TrailingStop = new("trailing_stop");

    public static OrderType FromValue(string value) => FromValueCore(value);
}
