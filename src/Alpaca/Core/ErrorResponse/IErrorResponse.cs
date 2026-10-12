using System.Threading;
using System.Threading.Tasks;
using Alpaca.Core.Models;

namespace Alpaca.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}