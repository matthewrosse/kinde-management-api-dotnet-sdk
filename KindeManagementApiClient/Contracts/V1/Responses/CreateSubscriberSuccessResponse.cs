using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses;

public record CreateSubscriberSuccessResponse(
    [property: JsonPropertyName("subscriber")]
    CreateSubscriberSuccessResponseInnerSubscriber Subscriber
);

public record CreateSubscriberSuccessResponseInnerSubscriber(
    [property: JsonPropertyName("subscriber_id")]
    string SubscriberId
);