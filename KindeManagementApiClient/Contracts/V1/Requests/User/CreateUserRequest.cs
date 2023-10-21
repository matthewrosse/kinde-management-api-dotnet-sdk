using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.User;

public record CreateUserRequest
{
    [JsonPropertyName("profile")] public required UserProfileModel Profile { get; init; }

    [JsonPropertyName("identities")] public required ICollection<UserIdentityModel> Identities { get; init; }
}

public record UserProfileModel
{
    [JsonPropertyName("given_name")] public string? GivenName { get; init; }

    [JsonPropertyName("family_name")] public string? FamilyName { get; init; }
}

public record UserIdentityModel
{
    [JsonPropertyName("type")] public required string Type { get; init; }

    [JsonPropertyName("details")] public required UserIdentityDetailsModel Details { get; init; }
}

public record UserIdentityDetailsModel
{
    [JsonPropertyName("email")] public required string Email { get; init; }
}