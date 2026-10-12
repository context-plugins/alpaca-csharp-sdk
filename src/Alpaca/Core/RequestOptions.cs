using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using Alpaca.Core.Hooks;

namespace Alpaca.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }

    public IReadOnlyList<SdkHook>? Hooks { get; init; }
}
