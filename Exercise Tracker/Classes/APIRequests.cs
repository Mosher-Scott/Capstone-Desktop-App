using System.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Exercise_Tracker.Classes
{
    public class APIRequests
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        public SecureToken savedToken;

        public string allClientDetailsEndpoint = "https://frozen-meadow-69055.herokuapp.com/clients";
        public string singleClientDetailEndpoint = "https://frozen-meadow-69055.herokuapp.com/clients/";

        public string allMuscleGroupsEndpoint = "https://frozen-meadow-69055.herokuapp.com/musclegroups";
        public string allTrainingSessionsEndpoint = "https://frozen-meadow-69055.herokuapp.com/trainingsessions";

        public string allExercisesEndpoint = "https://frozen-meadow-69055.herokuapp.com/exercises";

        public APIRequests()
        {

        }

        /// <summary>
        /// Gets an authorization token from the service to access the endpoints
        /// </summary>
        public void GetAuthToken()
        {

            var clientId = ConfigurationManager.AppSettings.Get("apiClientId");
            var clientSecret = ConfigurationManager.AppSettings.Get("apiClientSecret");

            string body = "{\"client_id\":\"" + clientId + "\",\"client_secret\":\"" + clientSecret + "\",\"audience\":\"https://capstone-api-auth\",\"grant_type\":\"client_credentials\"}";

            var client = new RestClient("https://dev-w4x3pv3a.us.auth0.com/oauth/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", $"{body}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            var queryResult = client.Execute(request).ToString();

            var content = response.Content;

            SecureToken responseFromSite = new SecureToken();

            try
            {
                responseFromSite = JsonConvert.DeserializeObject<SecureToken>(response.Content);
            } catch (Exception ex)
            {
                logger.Info($"Error getting token. {ex.Message}");
            }
            
            savedToken = responseFromSite;
        }

        /// <summary>
        /// Generic function to get data from the API endpoints.  Returns a JSON string
        /// </summary>
        /// <param name="url">URL of he website you want to access</param>
        /// <returns></returns>
        public string GetWebsiteData(string url)
        {
            GetAuthToken();

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            
            request.AddHeader("authorization", "Bearer " + savedToken.access_Token);
            IRestResponse response = client.Execute(request);

            var content = response.Content;

            return content;
        }
    } // end of class

    /// <summary>
    /// Holds the secure token data that is used for authentication
    /// </summary>
    public class SecureToken
    {
        public string access_Token { get; set; }
        public int expires_in { get; set; }

        public string token_type { get; set; }
    }
}
