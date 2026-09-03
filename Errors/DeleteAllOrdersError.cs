using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TraderApi.Core.ErrorResponse;
using TraderApi.Core.Models;

namespace TraderApi.Errors;

public sealed class DeleteAllOrdersError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteAllOrdersError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteAllOrdersError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static DeleteAllOrdersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<DeleteAllOrdersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteAllOrdersErrorResponse : IErrorResponse<DeleteAllOrdersError>
{
    public static DeleteAllOrdersErrorResponse Instance { get; } = new();

    private DeleteAllOrdersErrorResponse()
    {
    }

    public Task<DeleteAllOrdersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteAllOrdersError.Create(response, ct);
}
