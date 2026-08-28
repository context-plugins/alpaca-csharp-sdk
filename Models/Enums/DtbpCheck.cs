using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Models.Enums;

/// <summary>
/// both, entry, or exit. Controls Day Trading Margin Call (DTMC) checks.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DtbpCheck>))]
public sealed record DtbpCheck : StringEnum<DtbpCheck>
{
    private DtbpCheck(string value) : base(value)
    {
    }

    public static readonly DtbpCheck Both = new("both");

    public static readonly DtbpCheck Entry = new("entry");

    public static readonly DtbpCheck Exit = new("exit");

    public static DtbpCheck FromValue(string value) => FromValueCore(value);
}
