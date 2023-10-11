using System.Net;
using System.Net.Http.Headers;
using System.Net.Mime;
using Microsoft.Net.Http.Headers;
using Polly;

namespace Kinde.ApiClient;

public sealed class AuthorizationHeaderDelegatingHandler
    (IAuthTokenStore authTokenStore) : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        var token = await authTokenStore.GetAccessTokenAsync(CancellationToken.None);

        request.Headers.Authorization = new AuthenticationHeaderValue(KindeApiClientConstants.JwtBearerScheme, token);
        request.Headers.Add(HeaderNames.Accept, MediaTypeNames.Application.Json);

        var result = await Policy
            .HandleResult<HttpResponseMessage>(
                r => r.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden
            )
            .RetryAsync(1, async (_, _, _) =>
            {
                ApplyAccessTokenToAuthorizationHeader(
                    request,
                    await authTokenStore.RefreshAccessTokenAsync(cancellationToken)
                );
            })
            .ExecuteAsync(async () => await base
                .SendAsync(request, cancellationToken)
                .ConfigureAwait(false));

        var test = await result.Content.ReadAsStringAsync();

        return result;
    }

    private void ApplyAccessTokenToAuthorizationHeader(
        HttpRequestMessage request,
        string accessToken
    )
        => request.Headers.Authorization =
            new AuthenticationHeaderValue(KindeApiClientConstants.JwtBearerScheme, accessToken);
}