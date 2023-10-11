using System.Runtime.Serialization;

namespace Kinde.ApiClient.QueryParams;

public enum RoleSortingMethod
{
    [EnumMember(Value = "name_asc")] NameAscending,
    [EnumMember(Value = "name_desc")] NameDescending,
    [EnumMember(Value = "id_asc")] IdAscending,
    [EnumMember(Value = "id_desc")] IdDescending
}