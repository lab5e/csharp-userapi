/*
 * The User API
 *
 * API to manage teams, members and tokens
 *
 * The version of the OpenAPI document: 1.3.13 bordering-jerilyn
 * Contact: dev@lab5e.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Com.Lab5e.User.Client;
using Com.Lab5e.User.Api;
// uncomment below to import models
//using Com.Lab5e.User.Model;

namespace Com.Lab5e.User.Test.Api
{
    /// <summary>
    ///  Class for testing TokensApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TokensApiTests : IDisposable
    {
        private TokensApi instance;

        public TokensApiTests()
        {
            instance = new TokensApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TokensApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' TokensApi
            //Assert.IsType<TokensApi>(instance);
        }

        /// <summary>
        /// Test CreateToken
        /// </summary>
        [Fact]
        public void CreateTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Token body = null;
            //var response = instance.CreateToken(body);
            //Assert.IsType<Token>(response);
        }

        /// <summary>
        /// Test DeleteToken
        /// </summary>
        [Fact]
        public void DeleteTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.DeleteToken(token);
            //Assert.IsType<DeleteTokenResponse>(response);
        }

        /// <summary>
        /// Test ListTokens
        /// </summary>
        [Fact]
        public void ListTokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListTokens();
            //Assert.IsType<TokenList>(response);
        }

        /// <summary>
        /// Test RetrieveToken
        /// </summary>
        [Fact]
        public void RetrieveTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //var response = instance.RetrieveToken(token);
            //Assert.IsType<Token>(response);
        }

        /// <summary>
        /// Test UpdateToken
        /// </summary>
        [Fact]
        public void UpdateTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string token = null;
            //AnAPIToken body = null;
            //var response = instance.UpdateToken(token, body);
            //Assert.IsType<Token>(response);
        }
    }
}
