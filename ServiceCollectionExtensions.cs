using System;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Alpaca;

public static class ServiceCollectionExtensions
{
    extension(IServiceCollection services)
    {
        public IServiceCollection AddAlpacaClient(Action<AlpacaClientOptions>? configure = null)
        {
            var options = new AlpacaClientOptions();
            configure?.Invoke(options);
            services.AddHttpClient();
            services.AddSingleton(sp =>
                {
                    options.Logging =
                        options.Logging with
                        {
                            LoggerFactory = options.Logging.LoggerFactory ?? sp.GetService<ILoggerFactory>()
                        };
                    var httpClientFactory = sp.GetRequiredService<IHttpClientFactory>();
                    var httpClient = httpClientFactory.CreateClient();
                    return new AlpacaClient(httpClient, options);
                });
            return services;
        }
    }
}
