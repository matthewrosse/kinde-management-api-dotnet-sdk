namespace KindeManagementApiClient.Constants;

internal static class KindeApiClientConstants
{
    internal const string HttpClientName = "KindeHttpClient";
    internal const string JwtBearerScheme = "Bearer";
    internal const string AccessTokenCacheKey = "KindeAccessToken";
    internal const string GrantType = "client_credentials";

    internal class UrlEncodedKeys
    {
        internal const string GrantType = "grant_type";
        internal const string ClientId = "client_id";
        internal const string ClientSecret = "client_secret";
        internal const string Audience = "audience";
    }
}