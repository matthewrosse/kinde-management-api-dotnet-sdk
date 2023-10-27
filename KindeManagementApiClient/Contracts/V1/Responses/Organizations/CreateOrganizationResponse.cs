using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Responses.Organizations;

public record CreateOrganizationResponse(
    [property: JsonPropertyName("message")]
    string Message,
    [property: JsonPropertyName("code")] string Code,
    [property: JsonPropertyName("organization")]
    CreateOrganizationResponseInnerOrganization Organization
);

public record CreateOrganizationResponseInnerOrganization(
    [property: JsonPropertyName("code")] string Code
);