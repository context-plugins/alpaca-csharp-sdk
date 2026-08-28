using System;
using System.Text.Json.Serialization;
using Alpaca.Core.Models;

namespace Alpaca.Models;

/// <summary>
/// Represents the result of a request to cancel and order
/// </summary>
public record CanceledOrderResponse
{
    /// <summary>
    /// orderId
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public Guid? Id { get; init; }

    /// <summary>
    /// http response code
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public int? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
