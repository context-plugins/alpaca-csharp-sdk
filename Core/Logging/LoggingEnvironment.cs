using System;
using Microsoft.Extensions.Logging;
using TraderApi.Core.Configuration;

namespace TraderApi.Core.Logging;

internal static class LoggingEnvironment
{
    public static LoggingOptions Resolve(LoggingOptions current, string clientName)
    {
        if (current.LoggerFactory is not null)
            return current;

        var variableName = $"{clientName.ToUpperInvariant()}_LOG";
        var raw = Environment.GetEnvironmentVariable(variableName);
        if (!TryParseLevel(raw, out var level))
            return current;

        return level switch
        {
            LogLevel.Information => current with
            {
                LoggerFactory = new ConsoleErrorLoggerFactory(level),
            },
            LogLevel.Debug => current with
            {
                LoggerFactory = new ConsoleErrorLoggerFactory(level),
                LogRequestHeaders = true,
                LogResponseHeaders = true,
            },
            _ => current with
            {
                LoggerFactory = new ConsoleErrorLoggerFactory(level),
                LogRequestHeaders = true,
                LogResponseHeaders = true,
                LogRequestBody = true,
            },
        };
    }

    private static bool TryParseLevel(string? raw, out LogLevel level)
    {
        switch (raw?.Trim().ToLowerInvariant())
        {
            case "info":
                level = LogLevel.Information;
                return true;
            case "debug":
                level = LogLevel.Debug;
                return true;
            case "trace":
                level = LogLevel.Trace;
                return true;
            default:
                level = LogLevel.None;
                return false;
        }
    }
}
