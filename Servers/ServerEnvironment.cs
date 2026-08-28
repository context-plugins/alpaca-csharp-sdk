using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public record ServerEnvironment : StringEnum<ServerEnvironment>
{
    /// <summary>
    /// Paper trading — simulated money. Safe default.
    /// </summary>
    public static readonly ServerEnvironment Paper = new("Paper");
    /// <summary>
    /// Live trading — REAL money.
    /// </summary>
    public static readonly ServerEnvironment Live = new("Live");

    private ServerEnvironment(string value) : base(value)
    {
    }

    internal T Match<T>(Func<T> onPaper, Func<T> onLive) =>
        this switch
        {
            _ when this == Paper => onPaper(),
            _ when this == Live => onLive(),
            _ => throw new ArgumentOutOfRangeException(nameof(ServerEnvironment),
                this,
                $"Unknown {nameof(ServerEnvironment)} value.")
        };

    public static ServerEnvironment Default() => Paper;
}
