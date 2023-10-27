using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses.Organizations;

public record GetOrganizationsResponse
{
    [JsonIgnore] private readonly List<Organization>? _organizations;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("organizations")]
    public List<Organization> Organizations
    {
        get => _organizations ?? new();
        init => _organizations = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}