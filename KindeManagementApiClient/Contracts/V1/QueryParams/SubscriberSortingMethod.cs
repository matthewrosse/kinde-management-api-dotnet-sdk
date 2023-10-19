using System.Runtime.Serialization;

namespace KindeManagementApiClient.Contracts.V1.QueryParams;

public enum SubscriberSortingMethod
{
    [EnumMember(Value = "name_asc")] NameAscending,
    [EnumMember(Value = "name_desc")] NameDescending,
    [EnumMember(Value = "email_asc")] EmailAscending,
    [EnumMember(Value = "email_desc")] EmailDescending
}