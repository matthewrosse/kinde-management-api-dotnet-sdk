using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record UpdateOrganizationUsersResponse
{
    [JsonIgnore] private readonly List<string>? _usersAdded;

    [JsonIgnore] private readonly List<string>? _usersUpdated;

    [JsonIgnore] private readonly List<string>? _usersRemoved;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("users_added")]
    public List<string> UsersAdded
    {
        get => _usersAdded ?? new();
        init => _usersAdded = value;
    }

    [JsonPropertyName("users_updated")]
    public List<string> UsersUpdated
    {
        get => _usersUpdated ?? new();
        init => _usersUpdated = value;
    }

    [JsonPropertyName("users_removed")]
    public List<string> UsersRemoved
    {
        get => _usersRemoved ?? new();
        init => _usersRemoved = value;
    }
}