using System.Text.Json.Serialization;

namespace Kinde.ApiClient.Contracts.V1.Requests;

public record AddPermissionToUserInOrganizationRequest(
    [property: JsonPropertyName("permission_id")]
    string PermissionId
);