using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace KindeManagementApiClient.Contracts.V1.Requests.Organization;

public record UpdateOrganizationUsersRequest(
    [property: JsonPropertyName("users")] ICollection<UpdateOrganizationUserModel> UpdateUserModels
);

public record UpdateOrganizationUserModel
{
    [JsonPropertyName("id")] public required string Id { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("operation")]
    public UpdateOrganizationUserOperation? Operation { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("roles")]
    public ICollection<string>? Roles { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    [JsonPropertyName("permissions")]
    public ICollection<string>? Permissions { get; init; }
}

public enum UpdateOrganizationUserOperation
{
    [EnumMember(Value = "delete")] Delete
}