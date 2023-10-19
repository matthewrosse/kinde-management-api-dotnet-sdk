using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.User;

public record UpdateUserRequest
{
    public required string UserId { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("is_suspended")]
    public bool? IsSuspended { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("is_password_reset_requested")]
    public bool? IsPasswordResetRequested { get; init; }
}