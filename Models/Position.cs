using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TraderApi.Models.Enums;

namespace TraderApi.Models;

/// <summary>
/// The positions API provides information about an account’s current open positions. The response will include information such as cost basis, shares traded, and market value, which will be updated live as price information is updated. Once a position is closed, it will no longer be queryable through this API.
/// </summary>
public record Position
{
    /// <summary>
    /// Asset ID
    /// </summary>
    [JsonPropertyName("asset_id")]
    public required Guid AssetId { get; init; }

    /// <summary>
    /// Symbol name of the asset
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// Represents the current exchanges Alpaca supports. List is currently:
    /// <list type="bullet">
    ///   <item><description>AMEX</description></item>
    ///   <item><description>ARCA</description></item>
    ///   <item><description>BATS</description></item>
    ///   <item><description>NYSE</description></item>
    ///   <item><description>NASDAQ</description></item>
    ///   <item><description>NYSEARCA</description></item>
    ///   <item><description>OTC</description></item>
    /// </list>
    /// </summary>
    [JsonPropertyName("exchange")]
    public required Exchange Exchange { get; init; }

    /// <summary>
    /// Represents what class of asset this is. Currently only supports <c>us_equity</c> or <c>crypto</c>
    /// </summary>
    [JsonPropertyName("asset_class")]
    public required AssetClass AssetClass { get; init; }

    /// <summary>
    /// Average entry price of the position
    /// </summary>
    [JsonPropertyName("avg_entry_price")]
    [MinLength(1)]
    public required string AvgEntryPrice { get; init; }

    /// <summary>
    /// The number of shares
    /// </summary>
    [JsonPropertyName("qty")]
    [MinLength(1)]
    public required string Qty { get; init; }

    /// <summary>
    /// Total number of shares available minus open orders
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qty_available")]
    [MinLength(1)]
    public string? QtyAvailable { get; init; }

    /// <summary>
    /// “long”
    /// </summary>
    [JsonPropertyName("side")]
    [MinLength(1)]
    public required string Side { get; init; }

    /// <summary>
    /// Total dollar amount of the position
    /// </summary>
    [JsonPropertyName("market_value")]
    [MinLength(1)]
    public required string MarketValue { get; init; }

    /// <summary>
    /// Total cost basis in dollar
    /// </summary>
    [JsonPropertyName("cost_basis")]
    [MinLength(1)]
    public required string CostBasis { get; init; }

    /// <summary>
    /// Unrealized profit/loss in dollars
    /// </summary>
    [JsonPropertyName("unrealized_pl")]
    [MinLength(1)]
    public required string UnrealizedPl { get; init; }

    /// <summary>
    /// Unrealized profit/loss percent (by a factor of 1)
    /// </summary>
    [JsonPropertyName("unrealized_plpc")]
    [MinLength(1)]
    public required string UnrealizedPlpc { get; init; }

    /// <summary>
    /// Unrealized profit/loss in dollars for the day
    /// </summary>
    [JsonPropertyName("unrealized_intraday_pl")]
    [MinLength(1)]
    public required string UnrealizedIntradayPl { get; init; }

    /// <summary>
    /// Unrealized profit/loss percent (by a factor of 1)
    /// </summary>
    [JsonPropertyName("unrealized_intraday_plpc")]
    [MinLength(1)]
    public required string UnrealizedIntradayPlpc { get; init; }

    /// <summary>
    /// Current asset price per share
    /// </summary>
    [JsonPropertyName("current_price")]
    [MinLength(1)]
    public required string CurrentPrice { get; init; }

    /// <summary>
    /// Last day’s asset price per share based on the closing value of the last trading day
    /// </summary>
    [JsonPropertyName("lastday_price")]
    [MinLength(1)]
    public required string LastdayPrice { get; init; }

    /// <summary>
    /// Percent change from last day price (by a factor of 1)
    /// </summary>
    [JsonPropertyName("change_today")]
    [MinLength(1)]
    public required string ChangeToday { get; init; }

    [JsonPropertyName("asset_marginable")]
    public required bool AssetMarginable { get; init; }
}
