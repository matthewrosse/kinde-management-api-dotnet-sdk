namespace KindeManagementApiClient;

public interface IAuthTokenStore
{
    Task<string> GetAccessTokenAsync(CancellationToken cancellationToken);
    Task<string> RefreshAccessTokenAsync(CancellationToken cancellationToken);
}