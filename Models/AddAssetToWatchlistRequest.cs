using System.Text.Json.Serialization;
using TraderApi.Core.Models;

namespace TraderApi.Models;

/// <summary>
/// Append an asset for the symbol to the end of watchlist asset list
/// </summary>
public record AddAssetToWatchlistRequest
{
    /// <summary>
    /// symbol name to append to watchlist
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("symbol")]
    public string? Symbol { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
