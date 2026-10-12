using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Enum;

namespace Alpaca.Servers;

[JsonConverter(typeof(StringEnumConverter<ServerEnvironment>))]
public sealed record ServerEnvironment : ClosedStringEnum<ServerEnvironment>
{
    private ServerEnvironment(string value) : base(value)
    {
    }

    /// <summary>
    /// Paper trading — simulated money. Safe default.
    /// </summary>
    public static readonly ServerEnvironment Paper = new("Paper");

    /// <summary>
    /// Live trading — REAL money.
    /// </summary>
    public static readonly ServerEnvironment Live = new("Live");

    public static ServerEnvironment Default() => Paper;

    internal TResult Match<TResult>(Func<TResult> onPaper, Func<TResult> onLive) =>
        this switch
        {
            _ when this == Paper => onPaper(),
            _ when this == Live => onLive(),
            _ => throw new InvalidOperationException($"{nameof(ServerEnvironment)} holds no known value.")
        };
}
