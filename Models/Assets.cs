using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using TraderApi.Models.Enums;

namespace TraderApi.Models;

/// <summary>
/// The assets API serves as the master list of assets available for trade and data consumption from Alpaca. Assets are sorted by asset class, exchange and symbol. Some assets are only available for data consumption via Polygon, and are not tradable with Alpaca. These assets will be marked with the flag tradable=false.
/// </summary>
public record Assets
{
    /// <summary>
    /// Asset ID
    /// </summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    /// <summary>
    /// Represents what class of asset this is. Currently only supports <c>us_equity</c> or <c>crypto</c>
    /// </summary>
    [JsonPropertyName("class")]
    public required AssetClass Class { get; init; }

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
    /// The symbol of the asset
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }

    /// <summary>
    /// The official name of the asset
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// active or inactive
    /// </summary>
    [JsonPropertyName("status")]
    public required Status Status { get; init; }

    /// <summary>
    /// Asset is tradable on Alpaca or not
    /// </summary>
    [JsonPropertyName("tradable")]
    public required bool Tradable { get; init; }

    /// <summary>
    /// Asset is marginable or not
    /// </summary>
    [JsonPropertyName("marginable")]
    public required bool Marginable { get; init; }

    /// <summary>
    /// Asset is shortable or not
    /// </summary>
    [JsonPropertyName("shortable")]
    public required bool Shortable { get; init; }

    /// <summary>
    /// Asset is easy-to-borrow or not (filtering for easy_to_borrow = True is the best way to check whether the name is currently available to short at Alpaca).
    /// </summary>
    [JsonPropertyName("easy_to_borrow")]
    public required bool EasyToBorrow { get; init; }

    /// <summary>
    /// Asset is fractionable or not
    /// </summary>
    [JsonPropertyName("fractionable")]
    public required bool Fractionable { get; init; }
}
