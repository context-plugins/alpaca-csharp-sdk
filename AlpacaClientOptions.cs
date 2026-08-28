using System.Collections.Generic;
using Alpaca.Core.Configuration;
using Alpaca.Core.Hooks;
using Alpaca.Servers;

namespace Alpaca;

public class AlpacaClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public IReadOnlyList<SdkHook> Hooks { get; set; } = [];
    public string? ApiKey { get; set; }
    public string? ApiSecret { get; set; }
}
