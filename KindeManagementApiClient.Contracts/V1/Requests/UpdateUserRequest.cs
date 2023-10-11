using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record UpdateUserRequest(
    [property: JsonPropertyName("given_name")]
    string? GivenName,
    [property: JsonPropertyName("family_name")]
    string? FamilyName,
    [property: JsonPropertyName("is_suspended")]
    bool? IsSuspended,
    [property: JsonPropertyName("is_password_reset_requested")]
    bool? IsPasswordResetRequested
);