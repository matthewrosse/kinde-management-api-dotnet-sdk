using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using KindeManagementApiClient.Abstractions;
using KindeManagementApiClient.Constants;
using Microsoft.Net.Http.Headers;
using Polly;

namespace KindeManagementApiClient.Implementations;

/// <summary>
/// Delegating handler that sets the authorization header
/// before each request and handles unauthorized responses.
/// </summary>
public sealed class AuthorizationHeaderDelegatingHandler : DelegatingHandler
{
    private readonly IAuthTokenStore _authTokenStore;

    public AuthorizationHeaderDelegatingHandler(IAuthTokenStore authTokenStore)
    {
        _authTokenStore = authTokenStore;
    }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var token = await _authTokenStore.GetAccessTokenAsync(CancellationToken.None);

        request.Headers.Authorization = new AuthenticationHeaderValue(KindeApiClientConstants.JwtBearerScheme, token);
        request.Headers.Add(HeaderNames.Accept, MediaTypeNames.Application.Json);

        return await Policy
            .HandleResult<HttpResponseMessage>(
                r => r.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden
            )
            .RetryAsync(1, async (_, _, _) =>
            {
                ApplyAccessTokenToAuthorizationHeader(
                    request,
                    await _authTokenStore.GetRefreshedAccessTokenAsync(cancellationToken)
                );
            })
            .ExecuteAsync(async () => await base
                .SendAsync(request, cancellationToken)
                .ConfigureAwait(false));
    }

    private void ApplyAccessTokenToAuthorizationHeader(
        HttpRequestMessage request,
        string accessToken
    )
        => request.Headers.Authorization =
            new AuthenticationHeaderValue(KindeApiClientConstants.JwtBearerScheme, accessToken);
}