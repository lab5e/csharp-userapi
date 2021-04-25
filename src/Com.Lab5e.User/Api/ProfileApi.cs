/*
 * The User API
 *
 * API to manage teams, members and tokens
 *
 * The version of the OpenAPI document: 1.3.8 indivisible-esau
 * Contact: dev@lab5e.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Com.Lab5e.User.Client;
using Com.Lab5e.User.Model;

namespace Com.Lab5e.User.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfileApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Logged in profile
        /// </summary>
        /// <remarks>
        /// Show your user profile information
        /// </remarks>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserProfile</returns>
        UserProfile GetUserProfile();

        /// <summary>
        /// Logged in profile
        /// </summary>
        /// <remarks>
        /// Show your user profile information
        /// </remarks>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserProfile</returns>
        ApiResponse<UserProfile> GetUserProfileWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfileApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Logged in profile
        /// </summary>
        /// <remarks>
        /// Show your user profile information
        /// </remarks>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UserProfile</returns>
        System.Threading.Tasks.Task<UserProfile> GetUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Logged in profile
        /// </summary>
        /// <remarks>
        /// Show your user profile information
        /// </remarks>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UserProfile)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserProfile>> GetUserProfileWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProfileApi : IProfileApiSync, IProfileApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProfileApi : IProfileApi
    {
        private Com.Lab5e.User.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProfileApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProfileApi(String basePath)
        {
            this.Configuration = Com.Lab5e.User.Client.Configuration.MergeConfigurations(
                Com.Lab5e.User.Client.GlobalConfiguration.Instance,
                new Com.Lab5e.User.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Com.Lab5e.User.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Lab5e.User.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Com.Lab5e.User.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProfileApi(Com.Lab5e.User.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Com.Lab5e.User.Client.Configuration.MergeConfigurations(
                Com.Lab5e.User.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Com.Lab5e.User.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Com.Lab5e.User.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Com.Lab5e.User.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProfileApi(Com.Lab5e.User.Client.ISynchronousClient client, Com.Lab5e.User.Client.IAsynchronousClient asyncClient, Com.Lab5e.User.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Com.Lab5e.User.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Com.Lab5e.User.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Com.Lab5e.User.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Com.Lab5e.User.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Com.Lab5e.User.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Logged in profile Show your user profile information
        /// </summary>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>UserProfile</returns>
        public UserProfile GetUserProfile()
        {
            Com.Lab5e.User.Client.ApiResponse<UserProfile> localVarResponse = GetUserProfileWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Logged in profile Show your user profile information
        /// </summary>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of UserProfile</returns>
        public Com.Lab5e.User.Client.ApiResponse<UserProfile> GetUserProfileWithHttpInfo()
        {
            Com.Lab5e.User.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.User.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Com.Lab5e.User.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Lab5e.User.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (APIToken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<UserProfile>("/user/profile", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserProfile", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Logged in profile Show your user profile information
        /// </summary>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of UserProfile</returns>
        public async System.Threading.Tasks.Task<UserProfile> GetUserProfileAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Com.Lab5e.User.Client.ApiResponse<UserProfile> localVarResponse = await GetUserProfileWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Logged in profile Show your user profile information
        /// </summary>
        /// <exception cref="Com.Lab5e.User.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (UserProfile)</returns>
        public async System.Threading.Tasks.Task<Com.Lab5e.User.Client.ApiResponse<UserProfile>> GetUserProfileWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Com.Lab5e.User.Client.RequestOptions localVarRequestOptions = new Com.Lab5e.User.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Com.Lab5e.User.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Com.Lab5e.User.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (APIToken) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-API-Token")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-API-Token", this.Configuration.GetApiKeyWithPrefix("X-API-Token"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<UserProfile>("/user/profile", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetUserProfile", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
