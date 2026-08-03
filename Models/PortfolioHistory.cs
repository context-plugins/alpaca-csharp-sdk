using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TraderApi.Models;

public record PortfolioHistory
{
    /// <summary>
    /// time of each data element, left-labeled (the beginning of time window)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timestamp")]
    public IReadOnlyList<int>? Timestamp { get; init; }

    /// <summary>
    /// equity value of the account in dollar amount as of the end of each time window
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("equity")]
    public IReadOnlyList<double>? Equity { get; init; }

    /// <summary>
    /// profit/loss in dollar from the base value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profit_loss")]
    public IReadOnlyList<double>? ProfitLoss { get; init; }

    /// <summary>
    /// profit/loss in percentage from the base value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("profit_loss_pct")]
    public IReadOnlyList<double>? ProfitLossPct { get; init; }

    /// <summary>
    /// basis in dollar of the profit loss calculation
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("base_value")]
    public double? BaseValue { get; init; }

    /// <summary>
    /// time window size of each data element
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timeframe")]
    public string? Timeframe { get; init; }
}
