Kinde management API SDK for .NET
=================================
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/matthewrosse/kinde-management-api-dotnet-sdk/blob/main/LICENSE)

A convenient interface for consuming the Kinde Management API
that manages the access token refresh flow
and transient network errors for you.

> **Note**
> This library is still in development, so breaking changes are possible, althought I don't expect much to change in the
> interface.

### Installation

You should install [KindeManagementApiClient with NuGet](https://nuget.org/packages/KindeManagementApiClient)

```shell
dotnet add package KindeManagementApiClient
```

Or via Visual Studio Package Manager Console:

```shell
Install-Package KindeManagementApiClient
```

These commands will install the `KindeManagementApiClient` and all of its dependencies.

### Configure options

Before you start using the library you need to:

- create a Machine to machine (M2M) application and enable the Kinde Management API connection in
  the app's settings.
- add this configuration
  to your appsettings.json file or other json file that is added to your project.

```json
{
  "KindeApiClientOptions": {
    "ClientId": "your-client-id",
    "ClientSecret": "your-client-secret",
    "Domain": "https://<your-business-name>.kinde.com",
    "Audience": "https://<your-business-name>.kinde.com/api"
  }
}
```

> **Important**
> You must turn on the Kinde Management API in the settings of your Machine to machine application!!!
> Otherwise, your machine to machine app won't be whitelisted to get the OAuth2 token.

These settings are going to be validated
at the application start. If you forget to add them, or for example the domain isn't a valid URL,
you will get the `Microsoft.Extensions.Options.OptionsValidationException` exception.

### Registering with `IServiceCollection`

To register `KindeManagementApiClient` services:

```csharp
services.AddKindeApiClient();
```

This registers:

- `IKindeApiClient`
- `IMemoryCache`
- `IOptions<KindeApiClientOptions>`
- and some other internal services

And adds:

- `IAsyncRetryPolicy` to the http client which handles the transient network errors, as well as the 429 HTTP status code
  (too many requests).

### Usage

This library takes care of requesting and refreshing the access tokens for you,
so you don't have to do it yourself, just fill in the appsettings.json.

In order to consume the API, you need to inject the IKindeApiClient through the constructor:

```csharp
using FluentResults;

public sealed class MyAmazingService
{
    private readonly IKindeApiClient _client;
    
    public MyAmazingService(IKindeApiClient client)
        => _client = client;
    
    public async Task<User?> GetUserByIdAsync(string userId)
    {
        var response = await _client.GetUser(userId);
        
        if (!response.IsSuccessStatusCode)
        {
            return null;
        }
        
        return response.Content;
    }
    
    // since the client doesn't throw exceptions by default,
    // you can use something like FluentResults
    public async Task<Result<string>> CreateOrganizationAsync(string organizationName)
    {
        var response = await _client.CreateOrganization(new CreateOrganizationRequest
        {
            Name = organizationName,
            BackgroundColor = "#123456"
            // some other props
        });
        
        if (!response.IsSuccessStatusCode)
        {
            return Results.Fail(response.Error.Content);
        }
        
        var organizationCode = response.Content.Organization.Code; 
        
        return Results.Ok(organizationCode);
    }
}
```

Overall, the usage looks like this:

```csharp
await _client.CreateSomething(new CreateSomethingRequest 
{ 
    SomeProp = "someValue" 
});
await _client.UpdateSomething(new UpdateSomethingRequest 
{ 
    Name = "someName" 
});
await _client.DeleteSomething(someId);
await _client.GetSomething(someId);
await _client.GetSomethings();
await _client.GetSomethings(new GetSomethingsQueryFilter 
{ 
    SortingMethod = SomethingSortingMethod.NameDescending,
    PageSize = 25, 
    NextToken = "125213412-4123-4123-412"
});
```
