using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// Represents what class of asset this is. Currently only supports <c>us_equity</c> or <c>crypto</c>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<AssetClass>))]
public sealed record AssetClass : OpenStringEnum<AssetClass>
{
    private AssetClass(string value) : base(value)
    {
    }

    public static readonly AssetClass UsEquity = new("us_equity");

    public static readonly AssetClass Crypto = new("crypto");

    public TResult Match<TResult>(Func<TResult> onUsEquity, Func<TResult> onCrypto, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == UsEquity => onUsEquity(),
            _ when this == Crypto => onCrypto(),
            _ => otherwise(Value)
        };

    public void Match(Action onUsEquity, Action onCrypto, Action<string> otherwise)
    {
        if (this == UsEquity) onUsEquity();
        else if (this == Crypto) onCrypto();
        else otherwise(Value);
    }
}
