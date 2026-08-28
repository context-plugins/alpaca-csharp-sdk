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
public sealed record Exchange : StringEnum<Exchange>
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

    public static Exchange FromValue(string value) => FromValueCore(value);
}
