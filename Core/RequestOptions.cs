using Microsoft.Extensions.Logging;

namespace TraderApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
