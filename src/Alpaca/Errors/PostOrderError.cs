using System.Threading.Tasks;
using Alpaca.Core.ErrorResponse;
using Alpaca.Core.Models;

namespace Alpaca.Errors;

public sealed class PostOrderError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private PostOrderError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static PostOrderError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static PostOrderError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<PostOrderError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            403 or 422 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PostOrderError> Response { get; } = new(Create);
}
