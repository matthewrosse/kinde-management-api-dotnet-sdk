namespace KindeManagementApiClient.Abstractions;

public interface IAuthTokenStore
{
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken);
    Task<string> GetRefreshedAccessTokenAsync(CancellationToken cancellationToken);
}