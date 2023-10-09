using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record AddOrganizationUsersResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("users_added")]
    IReadOnlyCollection<string> UsersAdded
);