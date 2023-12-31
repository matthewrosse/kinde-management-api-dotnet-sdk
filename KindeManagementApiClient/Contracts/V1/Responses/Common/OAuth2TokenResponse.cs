using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Common;

public record OAuth2TokenResponse(
    [property: JsonPropertyName("access_token")]
    string AccessToken,
    [property: JsonPropertyName("expires_in")]
    int ExpiresIn,
    [property: JsonPropertyName("scope")] string Scope,
    [property: JsonPropertyName("token_type")]
    string TokenType
);