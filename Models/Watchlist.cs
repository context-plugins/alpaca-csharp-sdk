using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TraderApi.Models;

/// <summary>
/// The watchlist API provides CRUD operation for the account’s watchlist. An account can have multiple watchlists and each is uniquely identified by id but can also be addressed by user-defined name. Each watchlist is an ordered list of assets.
/// </summary>
public record Watchlist
{
    /// <summary>
    /// watchlist id
    /// </summary>
    [JsonPropertyName("id")]
    public required Guid Id { get; init; }

    /// <summary>
    /// account ID
    /// </summary>
    [JsonPropertyName("account_id")]
    public required Guid AccountId { get; init; }

    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    [JsonPropertyName("updated_at")]
    public required DateTimeOffset UpdatedAt { get; init; }

    /// <summary>
    /// user-defined watchlist name (up to 64 characters)
    /// </summary>
    [JsonPropertyName("name")]
    [MinLength(1)]
    public required string Name { get; init; }

    /// <summary>
    /// the content of this watchlist, in the order as registered by the client
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("assets")]
    public IReadOnlyList<Assets>? Assets { get; init; }
}
