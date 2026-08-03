using TraderApi.Core.Models;

namespace TraderApi.Servers;

public class DefaultOptions
{
    public ProductionOptions Production { get; set; } = new();
    public Environment2Options Environment2 { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Production.BaseUrl, path, []),
            () => new UrlTemplate(Environment2.BaseUrl, path, []));

    public class ProductionOptions
    {
        public string BaseUrl { get; set; } = "https://paper-api.alpaca.markets";
    }

    public class Environment2Options
    {
        public string BaseUrl { get; set; } = "https://api.alpaca.markets";
    }
}
