using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests.User;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

public partial interface IKindeApiClient
{
    [Get(KindeApiRoutes.V1.Users.Get)]
    Task<User> GetUser(string id);

    [Post(KindeApiRoutes.V1.Users.RefreshClaims)]
    Task<SuccessResponse> RefreshUserClaims(string userId);

    [Get(KindeApiRoutes.V1.Users.GetMany)]
    Task<UsersResponse> GetUsers(
        [Query] GetUsersRequest request
    );

    [Get(KindeApiRoutes.V1.Users.GetMany)]
    Task<UsersResponse> GetUsers();

    [Post(KindeApiRoutes.V1.Users.Create)]
    Task<CreateUserResponse> CreateUser([Body] CreateUserRequest request);

    [Patch(KindeApiRoutes.V1.Users.Update)]
    Task<UpdateUserResponse> UpdateUser([Body] UpdateUserRequest request);

    [Delete(KindeApiRoutes.V1.Users.Delete)]
    Task<SuccessResponse> DeleteUser(string id, [AliasAs("is_delete_profile")] bool shouldDeleteProfile = false);
}