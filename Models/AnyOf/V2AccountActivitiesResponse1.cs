using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using TraderApi.Core.Extensions;
using TraderApi.Core.Models;

namespace TraderApi.Models.AnyOf;

/// <summary>
/// Will be one of a TradingActivity or NonTradeActivity based on activity_type used in path
/// </summary>
[JsonConverter(typeof(V2AccountActivitiesResponse1Converter))]
public record V2AccountActivitiesResponse1
{
    private readonly Optional<AccountTradingActivities> _accountTradingActivitiesValue;

    private readonly Optional<AccountNonTradeActivities> _accountNonTradeActivitiesValue;

    private V2AccountActivitiesResponse1(Optional<AccountTradingActivities> accountTradingActivitiesValue,
        Optional<AccountNonTradeActivities> accountNonTradeActivitiesValue)
    {
        _accountTradingActivitiesValue = accountTradingActivitiesValue;
        _accountNonTradeActivitiesValue = accountNonTradeActivitiesValue;
    }

    public static V2AccountActivitiesResponse1 AccountTradingActivities(AccountTradingActivities value) =>
        new(Optional<AccountTradingActivities>.Some(value), default);

    public static V2AccountActivitiesResponse1 AccountNonTradeActivities(AccountNonTradeActivities value) =>
        new(default, Optional<AccountNonTradeActivities>.Some(value));

    public bool TryGetAccountTradingActivities(out AccountTradingActivities value) =>
        _accountTradingActivitiesValue.TryGetValue(out value);

    public bool TryGetAccountNonTradeActivities(out AccountNonTradeActivities value) =>
        _accountNonTradeActivitiesValue.TryGetValue(out value);

    public static implicit operator V2AccountActivitiesResponse1(AccountTradingActivities value) =>
        AccountTradingActivities(value);

    public static implicit operator V2AccountActivitiesResponse1(AccountNonTradeActivities value) =>
        AccountNonTradeActivities(value);
}

file sealed class V2AccountActivitiesResponse1Converter : JsonConverter<V2AccountActivitiesResponse1>
{
    public override V2AccountActivitiesResponse1 Read(ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options)
    {
        using var doc = JsonDocument.ParseValue(ref reader);
        var root = doc.RootElement;
        if (JsonSerializer.TryDeserialize<AccountTradingActivities>(root,
            options,
            out var accountTradingActivitiesValue))
        {
            return V2AccountActivitiesResponse1.AccountTradingActivities(accountTradingActivitiesValue);
        }
        if (JsonSerializer.TryDeserialize<AccountNonTradeActivities>(root,
            options,
            out var accountNonTradeActivitiesValue))
        {
            return V2AccountActivitiesResponse1.AccountNonTradeActivities(accountNonTradeActivitiesValue);
        }
        throw new JsonException($"JSON does not match AccountTradingActivities or AccountNonTradeActivities schemas: {root.ToString()}");
    }

    public override void Write(Utf8JsonWriter writer,
        V2AccountActivitiesResponse1 value,
        JsonSerializerOptions options)
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
            throw new JsonException($"{nameof(V2AccountActivitiesResponse1)} contains no valid value to serialize.");
        }
    }
}
