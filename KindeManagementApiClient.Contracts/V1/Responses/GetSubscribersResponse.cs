using System.Text.Json.Serialization;
using KindeManagementApiClient.Contracts.V1.Models;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record GetSubscribersResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("subscribers")]
    IReadOnlyCollection<SubscribersSubscriber> Subscribers,
    [property: JsonPropertyName("next_token")]
    string NextToken
);