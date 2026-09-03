<!-- Generated file — do not edit; regenerated with the SDK. -->

# AccountConfigurationsApi — operations

Accessor: `client.AccountConfigurationsApi` · Source: `Api/AccountConfigurationsApi.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### GetAccountConfig

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `GetAccountConfig(RequestOptions? requestOptions = null, CancellationToken ct = default)`
- **Returns**: `AccountConfigurations`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountConfigurations` | `Models/AccountConfigurations.cs` |

### PatchAccountConfig

- **Auth**: `options.ApiKey` AND `options.ApiSecret`
- **Signature**: `PatchAccountConfig(AccountConfigurations? body, RequestOptions? requestOptions = null, CancellationToken ct = default)`
  - `body` — nullable, no default → **must pass explicitly**
- **Returns**: `AccountConfigurations`
- **Error**: `SdkException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `AccountConfigurations` | `Models/AccountConfigurations.cs` |

