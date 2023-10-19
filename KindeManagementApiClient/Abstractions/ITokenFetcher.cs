namespace KindeManagementApiClient.Abstractions;

internal interface ITokenFetcher
{
    Task<string> FetchAccessTokenAsync(CancellationToken cancellationToken = default);
}