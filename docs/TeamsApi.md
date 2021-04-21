# Com.Lab5e.User.Api.TeamsApi

All URIs are relative to *https://api.lab5e.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AcceptInvite**](TeamsApi.md#acceptinvite) | **POST** /user/teams/accept | Accept invite
[**CreateTeam**](TeamsApi.md#createteam) | **POST** /user/teams | Create team
[**DeleteInvite**](TeamsApi.md#deleteinvite) | **DELETE** /user/teams/{teamId}/invites/{code} | Delete invite
[**DeleteMember**](TeamsApi.md#deletemember) | **DELETE** /user/teams/{teamId}/members/{userId} | Remove member
[**DeleteTeam**](TeamsApi.md#deleteteam) | **DELETE** /user/teams/{teamId} | Remove team
[**GenerateInvite**](TeamsApi.md#generateinvite) | **POST** /user/teams/{teamId}/invites | Generate invite
[**ListInvites**](TeamsApi.md#listinvites) | **GET** /user/teams/{teamId}/invites | List invites
[**ListTeams**](TeamsApi.md#listteams) | **GET** /user/teams | List teams
[**RetrieveInvite**](TeamsApi.md#retrieveinvite) | **GET** /user/teams/{teamId}/invites/{code} | Retrieve invite
[**RetrieveMember**](TeamsApi.md#retrievemember) | **GET** /user/teams/{teamId}/members/{userId} | Retrieve member
[**RetrieveTeam**](TeamsApi.md#retrieveteam) | **GET** /user/teams/{teamId} | Retrieve team
[**RetrieveTeamMembers**](TeamsApi.md#retrieveteammembers) | **GET** /user/teams/{teamId}/members | List members
[**UpdateMember**](TeamsApi.md#updatemember) | **PATCH** /user/teams/{teamId}/members/{userId} | Update member
[**UpdateTeam**](TeamsApi.md#updateteam) | **PATCH** /user/teams/{teamId} | Update team


<a name="acceptinvite"></a>
# **AcceptInvite**
> Team AcceptInvite (AcceptInviteRequest body)

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
    public class AcceptInviteExample
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
                Team result = apiInstance.AcceptInvite(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.AcceptInvite: " + e.Message );
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

<a name="createteam"></a>
# **CreateTeam**
> Team CreateTeam (Team body)

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
    public class CreateTeamExample
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
                Team result = apiInstance.CreateTeam(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.CreateTeam: " + e.Message );
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

<a name="deleteinvite"></a>
# **DeleteInvite**
> DeleteInviteResponse DeleteInvite (string teamId, string code)

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
    public class DeleteInviteExample
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
                DeleteInviteResponse result = apiInstance.DeleteInvite(teamId, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteInvite: " + e.Message );
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

[**DeleteInviteResponse**](DeleteInviteResponse.md)

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

<a name="deletemember"></a>
# **DeleteMember**
> Member DeleteMember (string teamId, string userId)

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
    public class DeleteMemberExample
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
                Member result = apiInstance.DeleteMember(teamId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteMember: " + e.Message );
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

<a name="deleteteam"></a>
# **DeleteTeam**
> Team DeleteTeam (string teamId)

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
    public class DeleteTeamExample
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
                Team result = apiInstance.DeleteTeam(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.DeleteTeam: " + e.Message );
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

<a name="generateinvite"></a>
# **GenerateInvite**
> Invite GenerateInvite (string teamId, InviteRequest body)

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
    public class GenerateInviteExample
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
                Invite result = apiInstance.GenerateInvite(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.GenerateInvite: " + e.Message );
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

<a name="listinvites"></a>
# **ListInvites**
> InviteList ListInvites (string teamId)

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
    public class ListInvitesExample
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
                InviteList result = apiInstance.ListInvites(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ListInvites: " + e.Message );
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

<a name="listteams"></a>
# **ListTeams**
> TeamList ListTeams ()

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
    public class ListTeamsExample
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
                TeamList result = apiInstance.ListTeams();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ListTeams: " + e.Message );
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

<a name="retrieveinvite"></a>
# **RetrieveInvite**
> Invite RetrieveInvite (string teamId, string code)

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
    public class RetrieveInviteExample
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
                Invite result = apiInstance.RetrieveInvite(teamId, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.RetrieveInvite: " + e.Message );
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

<a name="retrievemember"></a>
# **RetrieveMember**
> Member RetrieveMember (string teamId, string userId)

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
    public class RetrieveMemberExample
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
                Member result = apiInstance.RetrieveMember(teamId, userId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.RetrieveMember: " + e.Message );
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

<a name="retrieveteam"></a>
# **RetrieveTeam**
> Team RetrieveTeam (string teamId)

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
    public class RetrieveTeamExample
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
                Team result = apiInstance.RetrieveTeam(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.RetrieveTeam: " + e.Message );
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

<a name="retrieveteammembers"></a>
# **RetrieveTeamMembers**
> MemberList RetrieveTeamMembers (string teamId)

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
    public class RetrieveTeamMembersExample
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
                MemberList result = apiInstance.RetrieveTeamMembers(teamId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.RetrieveTeamMembers: " + e.Message );
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

<a name="updatemember"></a>
# **UpdateMember**
> Member UpdateMember (string teamId, string userId, Member body)

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
    public class UpdateMemberExample
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
                Member result = apiInstance.UpdateMember(teamId, userId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UpdateMember: " + e.Message );
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

<a name="updateteam"></a>
# **UpdateTeam**
> Team UpdateTeam (string teamId, Team body)

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
    public class UpdateTeamExample
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
                Team result = apiInstance.UpdateTeam(teamId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.UpdateTeam: " + e.Message );
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

