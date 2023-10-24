using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.User;

/// <summary>
/// A request body object for updating a user.
/// </summary>
public record UpdateUserRequest
{
    /// <summary>
    /// The user's given name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The user's family name.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }

    /// <summary>
    /// Specifies whether the user's account is suspended.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("is_suspended")]
    public bool? IsSuspended { get; init; }

    /// <summary>
    /// Specifies whether the user needs to reset their password on the next sign in.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("is_password_reset_requested")]
    public bool? IsPasswordResetRequested { get; init; }
}