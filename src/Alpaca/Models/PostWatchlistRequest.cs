using System.Collections.Generic;
using System.Text.Json.Serialization;
using Alpaca.Core.Models;

namespace Alpaca.Models;

/// <summary>
/// Request format used for creating a new watchlist or updating an existing watchlist with a set of assets and name.
/// </summary>
public record PostWatchlistRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("symbols")]
    public IReadOnlyList<string?>? Symbols { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
