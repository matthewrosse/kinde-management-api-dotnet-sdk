using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record CreateUserRequest
{
    [JsonPropertyName("profile")] public UserProfileModel? Profile { get; init; }

    [JsonPropertyName("identities")] public ICollection<UserIdentityModel>? Identities { get; init; }
}

public record UserProfileModel
{
    [JsonPropertyName("given_name")] public string? GivenName { get; init; }

    [JsonPropertyName("family_name")] public string? FamilyName { get; init; }
}

public record UserIdentityModel
{
    [JsonPropertyName("type")] public string? Type { get; init; }

    [JsonPropertyName("details")] public UserIdentityDetailsModel? Details { get; init; }
}

public record UserIdentityDetailsModel
{
    [JsonPropertyName("email")] public string? Email { get; init; }
}