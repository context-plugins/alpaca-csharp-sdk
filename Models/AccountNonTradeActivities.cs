using System;
using System.Text.Json.Serialization;
using TraderApi.Models.Enums;

namespace TraderApi.Models;

public record AccountNonTradeActivities
{
    /// <summary>
    /// - FILL
    ///   Order fills (both partial and full fills)
    /// <para>
    /// - TRANS
    ///   Cash transactions (both CSD and CSW)
    /// </para>
    /// <para>
    /// - MISC
    ///   Miscellaneous or rarely used activity types (All types except those in TRANS, DIV, or FILL)
    /// </para>
    /// <para>
    /// - ACATC
    ///   ACATS IN/OUT (Cash)
    /// </para>
    /// <para>
    /// - ACATS
    ///   ACATS IN/OUT (Securities)
    /// </para>
    /// <para>
    /// - CFEE
    ///   Crypto fee
    /// </para>
    /// <para>
    /// - CSD
    ///   Cash deposit(+)
    /// </para>
    /// <para>
    /// - CSW
    ///   Cash withdrawal(-)
    /// </para>
    /// <para>
    /// - DIV
    ///   Dividends
    /// </para>
    /// <para>
    /// - DIVCGL
    ///   Dividend (capital gain long term)
    /// </para>
    /// <para>
    /// - DIVCGS
    ///   Dividend (capital gain short term)
    /// </para>
    /// <para>
    /// - DIVFEE
    ///   Dividend fee
    /// </para>
    /// <para>
    /// - DIVFT
    ///   Dividend adjusted (Foreign Tax Withheld)
    /// </para>
    /// <para>
    /// - DIVNRA
    ///   Dividend adjusted (NRA Withheld)
    /// </para>
    /// <para>
    /// - DIVROC
    ///   Dividend return of capital
    /// </para>
    /// <para>
    /// - DIVTW
    ///   Dividend adjusted (Tefra Withheld)
    /// </para>
    /// <para>
    /// - DIVTXEX
    ///   Dividend (tax exempt)
    /// </para>
    /// <para>
    /// - FEE
    ///   Fee denominated in USD
    /// </para>
    /// <para>
    /// - INT
    ///   Interest (credit/margin)
    /// </para>
    /// <para>
    /// - INTNRA
    ///   Interest adjusted (NRA Withheld)
    /// </para>
    /// <para>
    /// - INTTW
    ///   Interest adjusted (Tefra Withheld)
    /// </para>
    /// <para>
    /// - JNL
    ///   Journal entry
    /// </para>
    /// <para>
    /// - JNLC
    ///   Journal entry (cash)
    /// </para>
    /// <para>
    /// - JNLS
    ///   Journal entry (stock)
    /// </para>
    /// <para>
    /// - MA
    ///   Merger/Acquisition
    /// </para>
    /// <para>
    /// - NC
    ///   Name change
    /// </para>
    /// <para>
    /// - OPASN
    ///   Option assignment
    /// </para>
    /// <para>
    /// - OPEXP
    ///   Option expiration
    /// </para>
    /// <para>
    /// - OPXRC
    ///   Option exercise
    /// </para>
    /// <para>
    /// - PTC
    ///   Pass Thru Charge
    /// </para>
    /// <para>
    /// - PTR
    ///   Pass Thru Rebate
    /// </para>
    /// <para>
    /// - REORG
    ///   Reorg CA
    /// </para>
    /// <para>
    /// - SC
    ///   Symbol change
    /// </para>
    /// <para>
    /// - SSO
    ///   Stock spinoff
    /// </para>
    /// <para>
    /// - SSP
    ///   Stock split
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("activity_type")]
    public ActivityType? ActivityType { get; init; }

    /// <summary>
    /// An ID for the activity, always in “::” format. Can be sent as page_token in requests to facilitate the paging of results.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The date on which the activity occurred or on which the transaction associated with the activity settled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("date")]
    public DateTimeOffset? Date { get; init; }

    /// <summary>
    /// The net amount of money (positive or negative) associated with the activity.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("net_amount")]
    public string? NetAmount { get; init; }

    /// <summary>
    /// The symbol of the security involved with the activity. Not present for all activity types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("symbol")]
    public string? Symbol { get; init; }

    /// <summary>
    /// For dividend activities, the number of shares that contributed to the payment. Not present for other activity types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("qty")]
    public string? Qty { get; init; }

    /// <summary>
    /// For dividend activities, the average amount paid per share. Not present for other activity types.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("per_share_amount")]
    public string? PerShareAmount { get; init; }
}
