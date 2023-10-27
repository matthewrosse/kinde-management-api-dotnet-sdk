using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Subscribers;

public record CreateSubscriberSuccessResponse(
    [property: JsonPropertyName("subscriber")]
    CreateSubscriberSuccessResponseInnerSubscriber Subscriber
);

public record CreateSubscriberSuccessResponseInnerSubscriber(
    [property: JsonPropertyName("id")]
    string Id
);