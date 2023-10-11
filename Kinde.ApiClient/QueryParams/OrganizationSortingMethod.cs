using System.Runtime.Serialization;

namespace Kinde.ApiClient.QueryParams;

public enum OrganizationSortingMethod
{
    [EnumMember(Value = "name_asc")] NameAscending,
    [EnumMember(Value = "name_desc")] NameDescending,
    [EnumMember(Value = "email_asc")] EmailAscending,
    [EnumMember(Value = "email_desc")] EmailDescending
}