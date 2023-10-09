using System.Text.Json.Serialization;
using Kinde.ApiClient.Contracts.V1.Models;

namespace Kinde.ApiClient.Contracts.V1.Responses;

public record GetSubscriberResponse(
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("subscribers")]
    IReadOnlyCollection<Subscriber> Subscribers
);