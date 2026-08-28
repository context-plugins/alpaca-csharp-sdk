using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Open = new("open");

    public static readonly Status1 Closed = new("closed");

    public static readonly Status1 All = new("all");

    public static Status1 FromValue(string value) => FromValueCore(value);
}
