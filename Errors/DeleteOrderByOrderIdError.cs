using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Alpaca.Core.ErrorResponse;
using Alpaca.Core.Models;

namespace Alpaca.Errors;

public sealed class DeleteOrderByOrderIdError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteOrderByOrderIdError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteOrderByOrderIdError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DeleteOrderByOrderIdError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DeleteOrderByOrderIdError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            422 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteOrderByOrderIdErrorResponse : IErrorResponse<DeleteOrderByOrderIdError>
{
    public static DeleteOrderByOrderIdErrorResponse Instance { get; } = new();

    private DeleteOrderByOrderIdErrorResponse()
    {
    }

    public Task<DeleteOrderByOrderIdError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteOrderByOrderIdError.Create(response, ct);
}
