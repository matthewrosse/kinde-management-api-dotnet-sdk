using System.Runtime.Serialization;

namespace KindeManagementApiClient.Contracts.V1.QueryParams;

/// <summary>
/// An enum that specifies the sort method for endpoints that return a collection of permissions.
/// </summary>
public enum PermissionSortingMethod
{
    [EnumMember(Value = "name_asc")] NameAscending,
    [EnumMember(Value = "name_desc")] NameDescending,
    [EnumMember(Value = "id_asc")] IdAscending,
    [EnumMember(Value = "id_desc")] IdDescending
}