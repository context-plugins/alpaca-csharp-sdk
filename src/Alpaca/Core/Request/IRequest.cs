using System.Net.Http;

namespace Alpaca.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}