using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Applications;

public record GetApplicationsResponse
{
    [JsonIgnore] private readonly List<GetApplicationsResponseInnerApplication>? _applications;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("applications")]
    public List<GetApplicationsResponseInnerApplication>? Applications
    {
        get => _applications ?? new();
        init => _applications = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}

public record GetApplicationsResponseInnerApplication(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type
);