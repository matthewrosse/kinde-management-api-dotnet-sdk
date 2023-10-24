using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.User;

/// <summary>
/// A request body object for creating a new user.
/// </summary>
public record CreateUserRequest
{
    /// <summary>
    /// An instance of <see cref="UserProfileModel"/>.
    /// </summary>
    [JsonPropertyName("profile")]
    public required UserProfileModel Profile { get; init; }

    /// <summary>
    /// An instance of <see cref="ICollection{T}"/> of <see cref="UserIdentityModel"/>.
    /// </summary>
    [JsonPropertyName("identities")]
    public required ICollection<UserIdentityModel> Identities { get; init; }
}

/// <summary>
/// The user's profile model.
/// </summary>
public record UserProfileModel
{
    /// <summary>
    /// The user's given name.
    /// </summary>
    [JsonPropertyName("given_name")]
    public string? GivenName { get; init; }

    /// <summary>
    /// The user's family name.
    /// </summary>
    [JsonPropertyName("family_name")]
    public string? FamilyName { get; init; }
}

/// <summary>
/// The user's identity model.
/// </summary>
public record UserIdentityModel
{
    /// <summary>
    /// The identity's type.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// An instance of <see cref="UserIdentityDetailsModel"/>.
    /// </summary>
    [JsonPropertyName("details")]
    public required UserIdentityDetailsModel Details { get; init; }
}

/// <summary>
/// The user's identity details model.
/// </summary>
public record UserIdentityDetailsModel
{
    /// <summary>
    /// The user's identity email address.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }
}