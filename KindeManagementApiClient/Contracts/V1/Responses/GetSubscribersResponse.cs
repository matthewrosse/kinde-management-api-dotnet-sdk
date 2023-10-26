using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetSubscribersResponse
{
    [JsonIgnore] private readonly List<SubscribersSubscriber>? _subscribers;

    [JsonPropertyName("code")] public string Code { get; init; } = default!;

    [JsonPropertyName("message")] public string Message { get; init; } = default!;

    [JsonPropertyName("subscribers")]
    public List<SubscribersSubscriber> Subscribers
    {
        get => _subscribers ?? new();
        init => _subscribers = value;
    }

    [JsonPropertyName("next_token")] public string? NextToken { get; init; }
}