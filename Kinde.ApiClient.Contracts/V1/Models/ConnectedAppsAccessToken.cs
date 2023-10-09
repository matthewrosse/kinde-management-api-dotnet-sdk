using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Models;

public record ConnectedAppsAccessToken(
    [property: JsonPropertyName("access_token")]
    string AccessToken,
    [property: JsonPropertyName("access_token_expiry")]
    string AccessTokenExpiry
);