using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record UsersResponse
{
    [JsonIgnore] private readonly List<User>? _users;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("users")]
    public List<User> Users
    {
        get => _users ?? new();
        init => _users = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}