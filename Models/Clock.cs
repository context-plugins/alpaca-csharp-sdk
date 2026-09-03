using System;
using System.Text.Json.Serialization;
using TraderApi.Core.Models;

namespace TraderApi.Models;

public record Clock
{
    /// <summary>
    /// Current timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public DateTimeOffset? Timestamp { get; init; }

    /// <summary>
    /// Whether or not the market is open
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_open")]
    public bool? IsOpen { get; init; }

    /// <summary>
    /// Next Market open timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_open")]
    public DateTimeOffset? NextOpen { get; init; }

    /// <summary>
    /// Next market close timestamp
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("next_close")]
    public DateTimeOffset? NextClose { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
