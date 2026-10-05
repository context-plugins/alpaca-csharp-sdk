using System.Threading.Tasks;
using Alpaca.Core.ErrorResponse;
using Alpaca.Core.Models;

namespace Alpaca.Errors;

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

    private static Task<DeleteAllOpenPositionsError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            500 => response.RawBody().As(AsNoContent),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<DeleteAllOpenPositionsError> Response { get; } = new(Create);
}
