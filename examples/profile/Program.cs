using System;
using Com.Lab5e.User.Api;
using Com.Lab5e.User.Client;

namespace profile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pull the token from the command line. Run with `profile.exe [token]`
            // or `dotnet run -- [token]`
            if (args.Length < 1)
            {
                Console.WriteLine("Must specify token on command line");
                return;
            }

            // Set the token in the configuration
            var config = new Configuration();
            config.ApiKey["X-API-Token"] = args[0];

            // Create the API client
            var profileApi = new ProfileApi(config);

            try
            {
                // ..and retrieve the profile.
                var profile = profileApi.GetUserProfile();
                Console.WriteLine("Profile");
                Console.WriteLine("Name:       {0}", profile.Name);
                Console.WriteLine("Email:      {0}", profile.Email);
                Console.WriteLine("Avatar URL: {0}", profile.AvatarUrl);
            }
            catch (ApiException e)
            {
                // If something fails we'll get an ApiException
                Console.WriteLine("Got exception calling API: " + e.Message);
            }
        }
    }
}
