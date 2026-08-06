# Trader API

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The Trader API SDK for .NET provides access to the Trader API REST APIs from .NET applications.

Alpaca's Trading API is a modern platform for algorithmic trading.

For complete documentation on the Trading API and to obtain your keys head to https://alpaca.markets/docs/api-documentation/api-v2/. Once you have your keys, head to the environments tab to quickly get started.

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/TraderApi.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [TraderApiClientOptions](TraderApiClientOptions.cs).

```csharp
services.AddTraderApiClient(options =>
    {
        options.ApiKey = "YOUR_API_KEY";
        options.ApiSecret = "YOUR_API_KEY";
        options.Environment = ServerEnvironment.Paper;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [TraderApiClientOptions](TraderApiClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new TraderApiClientOptions
    {
        ApiKey = "YOUR_API_KEY",
        ApiSecret = "YOUR_API_KEY",
        Environment = ServerEnvironment.Paper,
    };
var client = new TraderApiClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `TraderApiClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

For further assistance, please contact support at support@alpaca.markets.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
