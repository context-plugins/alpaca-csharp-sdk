using System.Text.Json.Serialization;
using TraderApi.Core.Enum;

namespace TraderApi.Models.Enums;

/// <summary>
/// active or inactive
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Active = new("active");

    public static readonly Status Inactive = new("inactive");

    public static Status FromValue(string value) => FromValueCore(value);
}
