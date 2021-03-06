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
    ///  Class for testing ProfileApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProfileApiTests : IDisposable
    {
        private ProfileApi instance;

        public ProfileApiTests()
        {
            instance = new ProfileApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProfileApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ProfileApi
            //Assert.IsType<ProfileApi>(instance);
        }

        /// <summary>
        /// Test GetUserProfile
        /// </summary>
        [Fact]
        public void GetUserProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserProfile();
            //Assert.IsType<UserProfile>(response);
        }
    }
}
