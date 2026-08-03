using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TraderApi.Models;

public record Calendar
{
    /// <summary>
    /// Date string in “%Y-%m-%d” format
    /// </summary>
    [JsonPropertyName("date")]
    [MinLength(1)]
    public required string Date { get; init; }

    /// <summary>
    /// The time the market opens at on this date in “%H:%M” format
    /// </summary>
    [JsonPropertyName("open")]
    [MinLength(1)]
    public required string Open { get; init; }

    /// <summary>
    /// The time the market closes at on this date in “%H:%M” format
    /// </summary>
    [JsonPropertyName("close")]
    [MinLength(1)]
    public required string Close { get; init; }

    [JsonPropertyName("session_open")]
    [MinLength(1)]
    public required string SessionOpen { get; init; }

    [JsonPropertyName("session_close")]
    [MinLength(1)]
    public required string SessionClose { get; init; }
}
