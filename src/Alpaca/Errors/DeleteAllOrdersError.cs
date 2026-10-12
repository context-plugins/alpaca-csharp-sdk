using System.Threading.Tasks;
using Alpaca.Core.ErrorResponse;
using Alpaca.Core.Models;

namespace Alpaca.Errors;

public sealed class DeleteAllOrdersError : ApiError
{
    private readonly Optional<RawError> _noContentValue;

    private DeleteAllOrdersError(Optional<RawError> noContentValue, Optional<RawError> fallback) : base(fallback)
    {
        _noContentValue = noContentValue;
    }

    private static DeleteAllOrdersError AsNoContent(RawError value) => new(Optional<RawError>.Some(value), default);

    private static DeleteAllOrdersError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    private static Task<DeleteAllOrdersError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            500 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteAllOrdersError> Response { get; } = new(Create);
}
