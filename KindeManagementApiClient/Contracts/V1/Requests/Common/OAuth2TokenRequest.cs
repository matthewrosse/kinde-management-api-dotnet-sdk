using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Common;

/// <summary>
/// The request for oauth2 access token.
/// </summary>
/// <param name="ClientId">The client's identifier.</param>
/// <param name="ClientSecret">The client's secret.</param>
/// <param name="Audience">The client's audience.</param>
/// <param name="GrantType">The grant type.</param>
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