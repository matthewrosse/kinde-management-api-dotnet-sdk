using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests.User;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Users.Get)]
    Task<ApiResponse<User>> GetUser(string id);

    [Post(KindeApiRoutes.V1.Users.RefreshClaims)]
    Task<ApiResponse<SuccessResponse>> RefreshUserClaims(string userId);

    [Get(KindeApiRoutes.V1.Users.GetMany)]
    Task<ApiResponse<UsersResponse>> GetUsers(
        [Query] GetUsersRequest request
    );

    [Get(KindeApiRoutes.V1.Users.GetMany)]
    Task<ApiResponse<UsersResponse>> GetUsers();

    [Post(KindeApiRoutes.V1.Users.Create)]
    Task<ApiResponse<CreateUserResponse>> CreateUser([Body] CreateUserRequest request);

    [Patch(KindeApiRoutes.V1.Users.Update)]
    Task<ApiResponse<UpdateUserResponse>> UpdateUser([Body] UpdateUserRequest request);

    [Delete(KindeApiRoutes.V1.Users.Delete)]
    Task<ApiResponse<SuccessResponse>> DeleteUser(
        string id,
        [AliasAs("is_delete_profile")] bool shouldDeleteProfile = false
    );
}