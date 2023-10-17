using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record UpdateUserRequest
{
    [JsonPropertyName("given_name")] public string? GivenName { get; init; }

    [JsonPropertyName("family_name")] public string? FamilyName { get; init; }

    [JsonPropertyName("is_suspended")] public bool? IsSuspended { get; init; }

    [JsonPropertyName("is_password_reset_requested")]
    public bool? IsPasswordResetRequested { get; init; }
}