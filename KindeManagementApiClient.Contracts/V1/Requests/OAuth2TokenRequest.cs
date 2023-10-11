using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record OAuth2TokenRequest(
    [property: JsonPropertyName("client_id")]
    string ClientId,
    [property: JsonPropertyName("client_secret")]
    string ClientSecret,
    [property: JsonPropertyName("audience")]
    string Audience,
    [property: JsonPropertyName("grant_type")]
    string GrantType = "client_credentials"
);