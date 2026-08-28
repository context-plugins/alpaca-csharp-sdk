using System;
using System.Text.Json.Serialization;
using TraderApi.Core.Models;
using TraderApi.Models.Enums;

namespace TraderApi.Models;

/// <summary>
/// The account API serves important information related to an account, including account status, funds available for trade, funds available for withdrawal, and various flags relevant to an account’s ability to trade. An account maybe be blocked for just for trades (trades_blocked flag) or for both trades and transfers (account_blocked flag) if Alpaca identifies the account to engaging in any suspicious activity. Also, in accordance with FINRA’s pattern day trading rule, an account may be flagged for pattern day trading (pattern_day_trader flag), which would inhibit an account from placing any further day-trades. Please note that cryptocurrencies are not eligible assets to be used as collateral for margin accounts and will require the asset be traded using cash only.
/// </summary>
public record Account
{
    /// <summary>
    /// Account Id.
    /// </summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    /// <summary>
    /// Account number.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_number")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// An enum representing the various possible account status values.
    /// <para>
    /// Most likely, the account status is ACTIVE unless there is any problem. The account status may get in ACCOUNT_UPDATED when personal information is being updated from the dashboard, in which case you may not be allowed trading for a short period of time until the change is approved.
    /// </para>
    /// <para>
    /// - ONBOARDING
    ///   The account is onboarding.
    /// - SUBMISSION_FAILED
    ///   The account application submission failed for some reason.
    /// - SUBMITTED
    ///   The account application has been submitted for review.
    /// - ACCOUNT_UPDATED
    ///   The account information is being updated.
    /// - APPROVAL_PENDING
    ///   The final account approval is pending.
    /// - ACTIVE
    ///   The account is active for trading.
    /// - REJECTED
    ///   The account application has been rejected.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required AccountStatus Status { get; init; }

    /// <summary>
    /// USD
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("currency")]
    public string? Currency { get; init; }

    /// <summary>
    /// Cash Balance
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cash")]
    public string? Cash { get; init; }

    /// <summary>
    /// Total value of cash + holding positions (This field is deprecated. It is equivalent to the equity field.)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("portfolio_value")]
    public string? PortfolioValue { get; init; }

    /// <summary>
    /// Whether or not the account has been flagged as a pattern day trader
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("pattern_day_trader")]
    public bool? PatternDayTrader { get; init; }

    /// <summary>
    /// User setting. If true, the account is not allowed to place orders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trade_suspended_by_user")]
    public bool? TradeSuspendedByUser { get; init; }

    /// <summary>
    /// If true, the account is not allowed to place orders.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trading_blocked")]
    public bool? TradingBlocked { get; init; }

    /// <summary>
    /// If true, the account is not allowed to request money transfers.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("transfers_blocked")]
    public bool? TransfersBlocked { get; init; }

    /// <summary>
    /// If true, the account activity by user is prohibited.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("account_blocked")]
    public bool? AccountBlocked { get; init; }

    /// <summary>
    /// Timestamp this account was created at
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; init; }

    /// <summary>
    /// Flag to denote whether or not the account is permitted to short
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("shorting_enabled")]
    public bool? ShortingEnabled { get; init; }

    /// <summary>
    /// Real-time MtM value of all long positions held in the account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("long_market_value")]
    public string? LongMarketValue { get; init; }

    /// <summary>
    /// Real-time MtM value of all short positions held in the account
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("short_market_value")]
    public string? ShortMarketValue { get; init; }

    /// <summary>
    /// Cash + long_market_value + short_market_value
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("equity")]
    public string? Equity { get; init; }

    /// <summary>
    /// Equity as of previous trading day at 16:00:00 ET
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_equity")]
    public string? LastEquity { get; init; }

    /// <summary>
    /// Buying power multiplier that represents account margin classification; valid values 1 (standard limited margin account with 1x buying power), 2 (reg T margin account with 2x intraday and overnight buying power; this is the default for all non-PDT accounts with $2,000 or more equity), 4 (PDT account with 4x intraday buying power and 2x reg T overnight buying power)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("multiplier")]
    public string? Multiplier { get; init; }

    /// <summary>
    /// Current available $ buying power; If multiplier = 4, this is your daytrade buying power which is calculated as (last_equity - (last) maintenance_margin) * 4; If multiplier = 2, buying_power = max(equity – initial_margin,0) * 2; If multiplier = 1, buying_power = cash
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buying_power")]
    public string? BuyingPower { get; init; }

    /// <summary>
    /// Reg T initial margin requirement (continuously updated value)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("initial_margin")]
    public string? InitialMargin { get; init; }

    /// <summary>
    /// Maintenance margin requirement (continuously updated value)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("maintenance_margin")]
    public string? MaintenanceMargin { get; init; }

    /// <summary>
    /// Value of special memorandum account (will be used at a later date to provide additional buying_power)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sma")]
    public string? Sma { get; init; }

    /// <summary>
    /// The current number of daytrades that have been made in the last 5 trading days (inclusive of today)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("daytrade_count")]
    public int? DaytradeCount { get; init; }

    /// <summary>
    /// Your maintenance margin requirement on the previous trading day
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_maintenance_margin")]
    public string? LastMaintenanceMargin { get; init; }

    /// <summary>
    /// Your buying power for day trades (continuously updated value)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("daytrading_buying_power")]
    public string? DaytradingBuyingPower { get; init; }

    /// <summary>
    /// Your buying power under Regulation T (your excess equity - equity minus margin value - times your margin multiplier)
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("regt_buying_power")]
    public string? RegtBuyingPower { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
