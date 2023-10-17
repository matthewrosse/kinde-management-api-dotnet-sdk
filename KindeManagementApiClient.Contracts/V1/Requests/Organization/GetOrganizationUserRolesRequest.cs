using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record GetOrganizationUserRolesRequest(
    [property: JsonPropertyName("org_code")]
    string OrganizationCode,
    [property: JsonPropertyName("user_id")]
    string UserId
);