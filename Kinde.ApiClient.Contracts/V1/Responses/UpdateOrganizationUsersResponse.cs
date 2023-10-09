using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record UpdateOrganizationUsersResponse(
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("users_added")]
    IReadOnlyCollection<string> UsersAdded,
    [property: JsonPropertyName("users_updated")]
    IReadOnlyCollection<string> UsersUpdated,
    [property: JsonPropertyName("users_removed")]
    IReadOnlyCollection<string> UsersRemoved
);