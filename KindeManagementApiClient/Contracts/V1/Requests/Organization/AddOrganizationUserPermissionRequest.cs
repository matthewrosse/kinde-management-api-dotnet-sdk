using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

/// <summary>
/// A request for adding a permission to a user in an organization.
/// </summary>
/// <param name="PermissionId">The permission's identifier.</param>
public record AddOrganizationUserPermissionRequest(
    [property: JsonPropertyName("permission_id")]
    string PermissionId
);