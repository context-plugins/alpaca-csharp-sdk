using System.Text.Json.Serialization;
using TraderApi.Core.Enum;

namespace TraderApi.Models.Enums;

/// <summary>
/// fill or partial_fill
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeModel>))]
public sealed record TypeModel : StringEnum<TypeModel>
{
    private TypeModel(string value) : base(value)
    {
    }

    public static readonly TypeModel Fill = new("fill");

    public static readonly TypeModel PartialFill = new("partial_fill");

    public static TypeModel FromValue(string value) => FromValueCore(value);
}
