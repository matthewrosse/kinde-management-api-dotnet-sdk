using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests;
using KindeManagementApiClient.Contracts.V1.Responses;
using KindeManagementApiClient.QueryParams;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get("/api/v1/user")]
    Task<User> GetUser(string id);

    [Post("/api/v1/users/{user_id}/refresh_claims")]
    Task<SuccessResponse> RefreshUserClaims([AliasAs("user_id")] string userId);

    [Get("/api/v1/users")]
    Task<UsersResponse> GetUsers(
        [AliasAs("user_id")] string? userId = null,
        [AliasAs("email")] string? email = null,
        [AliasAs("sort")] UserSortingMethod? sortingMethod = null,
        [AliasAs("page_size")] int? pageSize = null,
        [AliasAs("next_token")] string? nextToken = null
    );

    [Post("/api/v1/user")]
    Task<CreateUserResponse> CreateUser([Body] CreateUserRequest request);

    [Patch("/api/v1/user")]
    Task<UpdateUserResponse> UpdateUser(string id, [Body] UpdateUserRequest request);

    [Delete("/api/v1/user")]
    Task<SuccessResponse> DeleteUser(string id, [AliasAs("is_delete_profile")] bool shouldDeleteProfile = false);
}