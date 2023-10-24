using System.Runtime.Serialization;

namespace KindeManagementApiClient.Contracts.V1.QueryParams;

/// <summary>
/// An enum that specifies the sort method for endpoints that return a collection of users.
/// </summary>
public enum UserSortingMethod
{
    [EnumMember(Value = "name_asc")] NameAscending,
    [EnumMember(Value = "name_desc")] NameDescending,
    [EnumMember(Value = "email_asc")] EmailAscending,
    [EnumMember(Value = "email_desc")] EmailDescending
}