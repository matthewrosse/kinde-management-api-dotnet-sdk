using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record UsersResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("users")] IReadOnlyCollection<User> Users,
    [property: JsonPropertyName("next_token")]
    string NextToken
);