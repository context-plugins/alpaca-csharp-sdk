using Alpaca.Models;

namespace Alpaca.Requests.AccountConfigurationsApi;

/// <summary>
/// The inputs of the PatchAccountConfig operation.
/// </summary>
public sealed record PatchAccountConfigRequest
{
    public AccountConfigurations? Body { get; init; }
}
