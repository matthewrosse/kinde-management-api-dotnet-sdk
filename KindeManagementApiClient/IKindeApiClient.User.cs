using KindeManagementApiClient.Constants;
using KindeManagementApiClient.Contracts.V1.Models;
using KindeManagementApiClient.Contracts.V1.Requests.User;
using KindeManagementApiClient.Contracts.V1.Responses;
using Refit;

namespace KindeManagementApiClient;

/// <summary>
/// Kinde management API client.
/// </summary>
public partial interface IKindeApiClient
{
    /// <summary>
    /// Gets the user with specified id.
    /// </summary>
    /// <param name="userId">User's identifier</param>
    /// <returns>An instance of <see cref="ApiResponse{T}" /> of <see cref="User"/>.</returns>
    [Get(KindeApiRoutes.V1.Users.Get)]
    Task<ApiResponse<User>> GetUser([Query, AliasAs("id")] string userId);

    /// <summary>
    /// Gets a collection of users with a default page size of 10.
    /// </summary>
    /// <param name="queryFilter">The <see cref="GetUsersQueryFilter"/> instance that represents additional query params.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="UsersResponse"/>.</returns>
    [Get(KindeApiRoutes.V1.Users.GetMany)]
    Task<ApiResponse<UsersResponse>> GetUsers([Query] GetUsersQueryFilter? queryFilter = default);

    /// <summary>
    /// Refreshes user claims.
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Users.RefreshClaims)]
    Task<ApiResponse<SuccessResponse>> RefreshUserClaims(string userId);

    /// <summary>
    /// Creates a new user.
    /// </summary>
    /// <param name="request">An instance of <see cref="CreateUserRequest"/> that contains information about new user.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="CreateUserResponse"/>.</returns>
    [Post(KindeApiRoutes.V1.Users.Create)]
    Task<ApiResponse<CreateUserResponse>> CreateUser([Body] CreateUserRequest request);

    /// <summary>
    /// Updates the user with specified id.
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <param name="request">An instance of <see cref="UpdateUserRequest"/> that contains properties to update.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="UpdateUserResponse"/>.</returns>
    [Patch(KindeApiRoutes.V1.Users.Update)]
    Task<ApiResponse<UpdateUserResponse>> UpdateUser(
        [Query, AliasAs("id")] string userId,
        [Body] UpdateUserRequest request
    );

    /// <summary>
    /// Deletes the user with specified id.
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <param name="shouldDeleteProfile">A <see cref="bool"/> value that specifies whether the user's profile should be deleted permanently.</param>
    /// <returns>An instance of <see cref="ApiResponse{T}"/> of <see cref="SuccessResponse"/>.</returns>
    [Delete(KindeApiRoutes.V1.Users.Delete)]
    Task<ApiResponse<SuccessResponse>> DeleteUser(
        [Query, AliasAs("id")] string userId,
        [AliasAs("is_delete_profile")] bool shouldDeleteProfile = false
    );
}