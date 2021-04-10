# Com.Lab5e.User.Api.TeamsApi

All URIs are relative to *https://api.lab5e.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UserAcceptInvite**](TeamsApi.md#useracceptinvite) | **POST** /user/teams/accept | Accept invite
[**UserCreateTeam**](TeamsApi.md#usercreateteam) | **POST** /user/teams | Create team
[**UserDeleteInvite**](TeamsApi.md#userdeleteinvite) | **DELETE** /user/teams/{teamId}/invites/{code} | Delete invite
[**UserDeleteMember**](TeamsApi.md#userdeletemember) | **DELETE** /user/teams/{teamId}/members/{userId} | Remove member
[**UserDeleteTeam**](TeamsApi.md#userdeleteteam) | **DELETE** /user/teams/{teamId} | Remove team
[**UserGenerateInvite**](TeamsApi.md#usergenerateinvite) | **POST** /user/teams/{teamId}/invites | Generate invite
[**UserListInvites**](TeamsApi.md#userlistinvites) | **GET** /user/teams/{teamId}/invites | List invites
[**UserListTeams**](TeamsApi.md#userlistteams) | **GET** /user/teams | List teams
[**UserRetrieveInvite**](TeamsApi.md#userretrieveinvite) | **GET** /user/teams/{teamId}/invites/{code} | Retrieve invite
[**UserRetrieveMember**](TeamsApi.md#userretrievemember) | **GET** /user/teams/{teamId}/members/{userId} | Retrieve member
[**UserRetrieveTeam**](TeamsApi.md#userretrieveteam) | **GET** /user/teams/{teamId} | Retrieve team
[**UserRetrieveTeamMembers**](TeamsApi.md#userretrieveteammembers) | **GET** /user/teams/{teamId}/members | List members
[**UserUpdateMember**](TeamsApi.md#userupdatemember) | **PATCH** /user/teams/{teamId}/members/{userId} | Update member
[**UserUpdateTeam**](TeamsApi.md#userupdateteam) | **PATCH** /user/teams/{teamId} | Update team


<a name="useracceptinvite"></a>
# **UserAcceptInvite**
> Team UserAcceptInvite (AcceptInviteRequest body)

Accept invite

Accept an invite from another user. This will add the currently logged in user to the team as a regular memeber. When the invite is accepted it is removed from the team's invites and cannot be reused.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserAcceptInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var body = new AcceptInviteRequest(); // AcceptInviteRequest | 

            try
            {
                // Accept invite
                Team result = apiInstance.UserAcceptInvite(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserAcceptInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AcceptInviteRequest**](AcceptInviteRequest.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usercreateteam"></a>
# **UserCreateTeam**
> Team UserCreateTeam (Team body)

Create team

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserCreateTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var body = new Team(); // Team | 

            try
            {
                // Create team
                Team result = apiInstance.UserCreateTeam(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserCreateTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Team**](Team.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userdeleteinvite"></a>
# **UserDeleteInvite**
> Object UserDeleteInvite (string teamId, string code)

Delete invite

Delete an invite created earlier. You must be an administrator of the team to perform this action

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserDeleteInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID
            var code = code_example;  // string | The invite code.

            try
            {
                // Delete invite
                Object result = apiInstance.UserDeleteInvite(teamId, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserDeleteInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 
 **code** | **string**| The invite code. | 

### Return type

**Object**

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userdeletemember"></a>
# **UserDeleteMember**
> Member UserDeleteMember (string teamId, string userId)

Remove member

Remove a member from the team. You must be an administrator to do this. You can't remove yourself from the team.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserDeleteMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID
            var userId = userId_example;  // string | The user ID

            try
            {
                // Remove member
                Member result = apiInstance.UserDeleteMember(teamId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserDeleteMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 
 **userId** | **string**| The user ID | 

### Return type

[**Member**](Member.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userdeleteteam"></a>
# **UserDeleteTeam**
> Team UserDeleteTeam (string teamId)

Remove team

Update the team. You must be an administrator of the team to edit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserDeleteTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID

            try
            {
                // Remove team
                Team result = apiInstance.UserDeleteTeam(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserDeleteTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 

### Return type

[**Team**](Team.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usergenerateinvite"></a>
# **UserGenerateInvite**
> Invite UserGenerateInvite (string teamId, InviteRequest body)

Generate invite

Update the team. You must be an administrator of the team to edit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserGenerateInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID
            var body = new InviteRequest(); // InviteRequest | 

            try
            {
                // Generate invite
                Invite result = apiInstance.UserGenerateInvite(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserGenerateInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 
 **body** | [**InviteRequest**](InviteRequest.md)|  | 

### Return type

[**Invite**](Invite.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userlistinvites"></a>
# **UserListInvites**
> InviteList UserListInvites (string teamId)

List invites

Update the team. You must be an administrator of the team to edit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserListInvitesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID

            try
            {
                // List invites
                InviteList result = apiInstance.UserListInvites(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserListInvites: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 

### Return type

[**InviteList**](InviteList.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userlistteams"></a>
# **UserListTeams**
> TeamList UserListTeams ()

List teams

Update the team. You must be an administrator of the team to edit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserListTeamsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);

            try
            {
                // List teams
                TeamList result = apiInstance.UserListTeams();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserListTeams: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TeamList**](TeamList.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userretrieveinvite"></a>
# **UserRetrieveInvite**
> Invite UserRetrieveInvite (string teamId, string code)

Retrieve invite

Read a single invite from the team's set of non-redeemed invites.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserRetrieveInviteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID
            var code = code_example;  // string | The invite code.

            try
            {
                // Retrieve invite
                Invite result = apiInstance.UserRetrieveInvite(teamId, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserRetrieveInvite: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 
 **code** | **string**| The invite code. | 

### Return type

[**Invite**](Invite.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userretrievemember"></a>
# **UserRetrieveMember**
> Member UserRetrieveMember (string teamId, string userId)

Retrieve member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserRetrieveMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID
            var userId = userId_example;  // string | The user ID

            try
            {
                // Retrieve member
                Member result = apiInstance.UserRetrieveMember(teamId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserRetrieveMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 
 **userId** | **string**| The user ID | 

### Return type

[**Member**](Member.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userretrieveteam"></a>
# **UserRetrieveTeam**
> Team UserRetrieveTeam (string teamId)

Retrieve team

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserRetrieveTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID

            try
            {
                // Retrieve team
                Team result = apiInstance.UserRetrieveTeam(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserRetrieveTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 

### Return type

[**Team**](Team.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userretrieveteammembers"></a>
# **UserRetrieveTeamMembers**
> MemberList UserRetrieveTeamMembers (string teamId)

List members

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserRetrieveTeamMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | The team ID

            try
            {
                // List members
                MemberList result = apiInstance.UserRetrieveTeamMembers(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserRetrieveTeamMembers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**| The team ID | 

### Return type

[**MemberList**](MemberList.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userupdatemember"></a>
# **UserUpdateMember**
> Member UserUpdateMember (string teamId, string userId, Member body)

Update member

You must be an administrator of the team to update member settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserUpdateMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | 
            var userId = userId_example;  // string | 
            var body = new Member(); // Member | 

            try
            {
                // Update member
                Member result = apiInstance.UserUpdateMember(teamId, userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserUpdateMember: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**|  | 
 **userId** | **string**|  | 
 **body** | [**Member**](Member.md)|  | 

### Return type

[**Member**](Member.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userupdateteam"></a>
# **UserUpdateTeam**
> Team UserUpdateTeam (string teamId, Team body)

Update team

Update the team. You must be an administrator of the team to edit it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Example
{
    public class UserUpdateTeamExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.lab5e.com";
            // Configure API key authorization: APIToken
            config.AddApiKey("X-API-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-API-Token", "Bearer");

            var apiInstance = new TeamsApi(config);
            var teamId = teamId_example;  // string | 
            var body = new Team(); // Team | 

            try
            {
                // Update team
                Team result = apiInstance.UserUpdateTeam(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UserUpdateTeam: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **teamId** | **string**|  | 
 **body** | [**Team**](Team.md)|  | 

### Return type

[**Team**](Team.md)

### Authorization

[APIToken](../README.md#APIToken)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A successful response. |  -  |
| **201** | It&#39;s created. |  -  |
| **400** | The request has an error. |  -  |
| **401** | You can&#39;t touch this |  -  |
| **404** | Couldn&#39;t find the resource. |  -  |
| **409** | There&#39;s a resource conflict here. |  -  |
| **500** | I&#39;m sorry. We are broken |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

