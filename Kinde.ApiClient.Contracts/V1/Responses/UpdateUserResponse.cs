using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record UpdateUserResponse(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("picture")]
    string Picture,
    [property: JsonPropertyName("given_name")]
    string GivenName,
    [property: JsonPropertyName("family_name")]
    string FamilyName,
    [property: JsonPropertyName("is_suspended")]
    bool IsSuspended,
    [property: JsonPropertyName("is_password_reset_requested")]
    bool IsPasswordResetRequested
);