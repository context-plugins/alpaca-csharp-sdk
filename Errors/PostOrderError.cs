using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using TraderApi.Core.ErrorResponse;
using TraderApi.Core.Models;

namespace TraderApi.Errors;

public sealed class PostOrderError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private PostOrderError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static PostOrderError AsNoContent(RawError value) =>
        new(Optional<RawError>.Some(value), default);

    private static PostOrderError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<PostOrderError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 422 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class PostOrderErrorResponse : IErrorResponse<PostOrderError>
{
    public static PostOrderErrorResponse Instance { get; } = new();

    private PostOrderErrorResponse()
    {
    }

    public Task<PostOrderError> Map(HttpResponseMessage response, CancellationToken ct) =>
        PostOrderError.Create(response, ct);
}
