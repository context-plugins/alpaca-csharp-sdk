using System.Text.Json.Serialization;
using TraderApi.Core.Enum;

namespace TraderApi.Models.Enums;

/// <summary>
/// Represents what class of asset this is. Currently only supports <c>us_equity</c> or <c>crypto</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetClass>))]
public sealed record AssetClass : StringEnum<AssetClass>
{
    private AssetClass(string value) : base(value)
    {
    }

    public static readonly AssetClass UsEquity = new("us_equity");

    public static readonly AssetClass Crypto = new("crypto");

    public static AssetClass FromValue(string value) => FromValueCore(value);
}
