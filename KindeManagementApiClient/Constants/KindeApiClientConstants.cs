namespace KindeManagementApiClient.Constants;

/// <summary>
/// Constants for kinde management api.
/// </summary>
internal static class KindeApiClientConstants
{
    /// <summary>
    /// Name for http client that interacts with kinde management api.
    /// </summary>
    internal const string HttpClientName = "KindeHttpClient";

    /// <summary>
    /// A scheme for kinde's management api auth token.
    /// </summary>
    internal const string JwtBearerScheme = "Bearer";

    /// <summary>
    /// The cache key used to obtain the access token.
    /// </summary>
    internal const string AccessTokenCacheKey = "KindeAccessToken";

    /// <summary>
    /// Grant type used to interact with kinde management api (machine to machine).
    /// </summary>
    internal const string GrantType = "client_credentials";

    /// <summary>
    /// The url encoded keys used in oauth2 token request's body.
    /// </summary>
    internal class UrlEncodedKeys
    {
        internal const string GrantType = "grant_type";
        internal const string ClientId = "client_id";
        internal const string ClientSecret = "client_secret";
        internal const string Audience = "audience";
    }
}