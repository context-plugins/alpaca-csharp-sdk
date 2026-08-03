using System.Text.Json.Serialization;
using TraderApi.Models.Enums;

namespace TraderApi.Models;

/// <summary>
/// The account configuration API provides custom configurations about your trading account settings. These configurations control various allow you to modify settings to suit your trading needs.
/// </summary>
public record AccountConfigurations
{
    /// <summary>
    /// both, entry, or exit. Controls Day Trading Margin Call (DTMC) checks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dtbp_check")]
    public DtbpCheck? DtbpCheck { get; init; }

    /// <summary>
    /// all or none. If none, emails for order fills are not sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trade_confirm_email")]
    public string? TradeConfirmEmail { get; init; }

    /// <summary>
    /// If true, new orders are blocked.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("suspend_trade")]
    public bool? SuspendTrade { get; init; }

    /// <summary>
    /// If true, account becomes long-only mode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("no_shorting")]
    public bool? NoShorting { get; init; }

    /// <summary>
    /// If true, account is able to participate in fractional trading
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fractional_trading")]
    public bool? FractionalTrading { get; init; }

    /// <summary>
    /// Can be "1" or "2"
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("max_margin_multiplier")]
    public string? MaxMarginMultiplier { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pdt_check")]
    public string? PdtCheck { get; init; }
}
