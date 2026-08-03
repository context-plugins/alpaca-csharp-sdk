using System;
using System.Text.Json.Serialization;
using TraderApi.Core.Enum;

namespace TraderApi.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public record ServerEnvironment : StringEnum<ServerEnvironment>
{
    /// <summary>
    /// Paper
    /// </summary>
    public static readonly ServerEnvironment Production = new("production");
    /// <summary>
    /// Live
    /// </summary>
    public static readonly ServerEnvironment Environment2 = new("environment2");

    private ServerEnvironment(string value) : base(value)
    {
    }

    internal T Match<T>(Func<T> onProduction, Func<T> onEnvironment2) =>
        this switch
        {
            _ when this == Production => onProduction(),
            _ when this == Environment2 => onEnvironment2(),
            _ => throw new ArgumentOutOfRangeException(nameof(ServerEnvironment),
                this,
                $"Unknown {nameof(ServerEnvironment)} value.")
        };

    public static ServerEnvironment Default() => Production;
}
