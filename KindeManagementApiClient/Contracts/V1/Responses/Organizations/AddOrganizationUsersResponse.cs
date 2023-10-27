using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Organizations;

public record AddOrganizationUsersResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("users_added")]
    IReadOnlyCollection<string> UsersAdded
);