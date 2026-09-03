using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TraderApi.Core.ErrorResponse;
using TraderApi.Core.Models;

namespace TraderApi.Errors;

public sealed class DeleteAllOpenPositionsError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteAllOpenPositionsError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteAllOpenPositionsError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DeleteAllOpenPositionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DeleteAllOpenPositionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteAllOpenPositionsErrorResponse : IErrorResponse<DeleteAllOpenPositionsError>
{
    public static DeleteAllOpenPositionsErrorResponse Instance { get; } = new();

    private DeleteAllOpenPositionsErrorResponse()
    {
    }

    public Task<DeleteAllOpenPositionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteAllOpenPositionsError.Create(response, ct);
}
