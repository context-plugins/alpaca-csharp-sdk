using TraderApi.Core.Configuration;
using TraderApi.Servers;

namespace TraderApi;

public class TraderApiClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    public string? ApiKey { get; set; }
    public string? ApiSecret { get; set; }
}
