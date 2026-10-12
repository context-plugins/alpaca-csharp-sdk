using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Alpaca.Core.Extensions;
using Alpaca.Core.Models;

namespace Alpaca.Models.AnyOf;

/// <summary>
/// Will be a mix of TradingActivity or NonTradeActivity objects based on what is passed in the activity_types parameter
/// </summary>
[JsonConverter(typeof(V2AccountActivitiesResponseConverter))]
public record V2AccountActivitiesResponse
{
    private readonly Optional<AccountTradingActivities> _accountTradingActivitiesValue;

    private readonly Optional<AccountNonTradeActivities> _accountNonTradeActivitiesValue;

    private V2AccountActivitiesResponse(Optional<AccountTradingActivities> accountTradingActivitiesValue,
        Optional<AccountNonTradeActivities> accountNonTradeActivitiesValue)
    {
        _accountTradingActivitiesValue = accountTradingActivitiesValue;
        _accountNonTradeActivitiesValue = accountNonTradeActivitiesValue;
    }

    public static V2AccountActivitiesResponse AccountTradingActivities(AccountTradingActivities value) =>
        new(Optional<AccountTradingActivities>.Some(value), default);

    public static V2AccountActivitiesResponse AccountNonTradeActivities(AccountNonTradeActivities value) =>
        new(default, Optional<AccountNonTradeActivities>.Some(value));

    public bool TryGetAccountTradingActivities(out AccountTradingActivities value) =>
        _accountTradingActivitiesValue.TryGetValue(out value);

    public bool TryGetAccountNonTradeActivities(out AccountNonTradeActivities value) =>
        _accountNonTradeActivitiesValue.TryGetValue(out value);

    public static implicit operator V2AccountActivitiesResponse(AccountTradingActivities value) =>
        AccountTradingActivities(value);

    public static implicit operator V2AccountActivitiesResponse(AccountNonTradeActivities value) =>
        AccountNonTradeActivities(value);
}

file sealed class V2AccountActivitiesResponseConverter : JsonConverter<V2AccountActivitiesResponse>
{
    public override V2AccountActivitiesResponse Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AccountTradingActivities>(
            root,
            options,
            out var accountTradingActivitiesValue))
        {
            return V2AccountActivitiesResponse.AccountTradingActivities(accountTradingActivitiesValue);
        }
        if (JsonSerializer.TryDeserialize<AccountNonTradeActivities>(
            root,
            options,
            out var accountNonTradeActivitiesValue))
        {
            return V2AccountActivitiesResponse.AccountNonTradeActivities(accountNonTradeActivitiesValue);
        }
        throw new JsonException(
            $"JSON does not match AccountTradingActivities or AccountNonTradeActivities schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer, V2AccountActivitiesResponse value, JsonSerializerOptions options)
    {
        if (value.TryGetAccountTradingActivities(out var accountTradingActivitiesValue))
        {
            JsonSerializer.Serialize(writer, accountTradingActivitiesValue, options);
        }
        else if (value.TryGetAccountNonTradeActivities(out var accountNonTradeActivitiesValue))
        {
            JsonSerializer.Serialize(writer, accountNonTradeActivitiesValue, options);
        }
        else
        {
            throw new JsonException($"{nameof(V2AccountActivitiesResponse)} contains no valid value to serialize.");
        }
    }
}
