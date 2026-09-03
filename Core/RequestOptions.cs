using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using TraderApi.Core.Hooks;

namespace TraderApi.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
