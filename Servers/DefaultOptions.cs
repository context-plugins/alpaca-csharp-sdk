using Alpaca.Core.Models;

namespace Alpaca.Servers;

public class DefaultOptions
{
    public PaperOptions Paper { get; set; } = new();
    public LiveOptions Live { get; set; } = new();

    internal UrlTemplate Resolve(ServerEnvironment environment, string path) =>
        environment.Match(() => new UrlTemplate(Paper.BaseUrl, path, []),
            () => new UrlTemplate(Live.BaseUrl, path, []));

    public class PaperOptions
    {
        public string BaseUrl { get; set; } = "https://paper-api.alpaca.markets";
    }

    public class LiveOptions
    {
        public string BaseUrl { get; set; } = "https://api.alpaca.markets";
    }
}
