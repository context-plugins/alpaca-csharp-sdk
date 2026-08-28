using System.Net.Http;
using Alpaca.Api;
using Alpaca.Core;
using Alpaca.Core.Logging;
using Alpaca.Core.Models;

namespace Alpaca;

/// <summary>
/// Alpaca's Trading API is a modern platform for algorithmic trading.
/// <para>
/// For complete documentation on the Trading API and to obtain your keys head to https://alpaca.markets/docs/api-documentation/api-v2/. Once you have your keys, head to the environments tab to quickly get started.
/// </para>
/// </summary>
public sealed class AlpacaClient
{
    public AlpacaClient(HttpClient httpClient, AlpacaClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "AlpacaClient/2.0.0 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "2.0.0"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "AlpacaClient");
        var rawClient =
            new RawClient(httpClient,
                urlFactory,
                httpStatusPolicy,
                headersFactory,
                resiliencePipelineFactory,
                httpLogger,
                options.Hooks);
        var auth = new AuthSchemes(options);
        AccountActivities = new AccountActivities(rawClient, server, auth);
        AccountConfigurationsApi = new AccountConfigurationsApi(rawClient, server, auth);
        Accounts = new Accounts(rawClient, server, auth);
        CalendarApi = new CalendarApi(rawClient, server, auth);
        ClockApi = new ClockApi(rawClient, server, auth);
        Orders = new Orders(rawClient, server, auth);
        PortfolioHistoryApi = new PortfolioHistoryApi(rawClient, server, auth);
        Positions = new Positions(rawClient, server, auth);
        Watchlists = new Watchlists(rawClient, server, auth);
    }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-references/trading-api/account-activities/ to view complete documentation on the Account Activities API.
    /// </summary>
    public AccountActivities AccountActivities { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-documentation/api-v2/account-configuration/ to view complete documentation on the Account Configurations API.
    /// </summary>
    public AccountConfigurationsApi AccountConfigurationsApi { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-references/trading-api/account/ to view complete documentation on the Accounts API.
    /// </summary>
    public Accounts Accounts { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-references/trading-api/calendar/ to view complete documentation on the Market Calendar API.
    /// </summary>
    public CalendarApi CalendarApi { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-references/trading-api/clock/ to view complete documentation on the Market Clock API.
    /// </summary>
    public ClockApi ClockApi { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-documentation/api-v2/orders/ to view complete documentation on the Orders API.
    /// </summary>
    public Orders Orders { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-documentation/api-v2/portfolio-history/ to view complete documentation on the Portfolio History API.
    /// </summary>
    public PortfolioHistoryApi PortfolioHistoryApi { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-documentation/api-v2/positions/ to view complete documentation on the Positions API.
    /// </summary>
    public Positions Positions { get; }

    /// <summary>
    /// Head to https://alpaca.markets/docs/api-documentation/api-v2/watchlist/ to view complete documentation on the Watchlist API.
    /// </summary>
    public Watchlists Watchlists { get; }
}
