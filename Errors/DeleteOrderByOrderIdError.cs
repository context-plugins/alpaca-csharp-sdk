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

    private static DeleteOrderByOrderIdError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<DeleteOrderByOrderIdError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            422 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteOrderByOrderIdError> Response { get; } = new(Create);
}
