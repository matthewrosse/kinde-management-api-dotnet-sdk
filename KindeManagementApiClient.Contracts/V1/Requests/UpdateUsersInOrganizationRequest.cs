using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests;

public record UpdateUsersInOrganizationRequest(
    [property: JsonPropertyName("users")] ICollection<UpdateOrganizationUserModel> UpdateUserModels
);

public record UpdateOrganizationUserModel
{
    [JsonPropertyName("id")] public required string Id { get; init; }

    [JsonPropertyName("operation")] public UpdateOrganizationUserOperation? Operation { get; init; }

    [JsonPropertyName("roles")] public ICollection<string>? Roles { get; init; }

    [JsonPropertyName("permissions")] public ICollection<string>? Permissions { get; init; }
}

public enum UpdateOrganizationUserOperation
{
    [EnumMember(Value = "delete")] Delete
}