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

        private static string devEnvironment = "http://localhost:80";
        private static string liveEnvironment = "https://frozen-meadow-69055.herokuapp.com";

        private static string environment = devEnvironment;

        public string allClientDetailsEndpoint = $"{environment}/clients";

        public string singleClientDetailEndpoint = $"{environment}/clients/";
        public string getSpecificWorkoutHistoryItem = $"{environment}/clients/workouthistory/";

        public string allMuscleGroupsEndpoint = $"{environment}/musclegroups";

        public string allTrainingSessionsEndpoint = $"{environment}/trainingsessions";
        public string singlegTrainingSessionEndpoint = $"{environment}/trainingsessions/";

        public string allExercisesEndpoint = $"{environment}/exercises";
        public string singleExercisesEndpoint = $"{environment}/exercises/";

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
        public string GetRequests(string url)
        {
            GetAuthToken();

            if(savedToken.access_Token == null)
            {
                return "([{data: \"Could not get auth token\"}])";
            }

            var client = new RestClient(url);
            var request = new RestRequest(Method.GET);
            
            request.AddHeader("authorization", "Bearer " + savedToken.access_Token);
            IRestResponse response = client.Execute(request);

            var content = response.Content;

            return content;
        }

        /// <summary>
        /// Creates and sends a PATCH request with all the data in the request body.  Used mainly for sending form data to the endpoint
        /// </summary>
        /// <param name="url">URL you are sending the request to</param>
        /// <param name="jsonData">The data you are sending to the API in JSON format</param>
        /// <returns>Response from the web server as a string</returns>
        public string SendPatchRequestDataInBody(string url, string jsonData)
        {
            GetAuthToken();

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.PATCH);
            request.AddHeader("authorization", "Bearer " + savedToken.access_Token);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", $"{jsonData}", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// Creates and sends a POST request with all the data in the request body.  Used mainly for sending form data to the endpoint
        /// </summary>
        /// <param name="url">URL you are sending the request to</param>
        /// <param name="jsonData">The data you are sending to the API in JSON format</param>
        /// <returns>Response from the web server as a string</returns>
        public string SendPOSTRequestDataInBody(string url, string jsonData)
        {
            GetAuthToken();

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "Bearer " + savedToken.access_Token);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", $"{jsonData}", ParameterType.RequestBody);

            logger.Info(request);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// For sending data to the API using a POST method
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string SendPostRequestData(string url)
        {
            GetAuthToken();

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("authorization", "Bearer " + savedToken.access_Token);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response.Content;
        }

        /// <summary>
        /// For sending delete requests to the API endpoints
        /// </summary>
        /// <param name="url">URL you are sending the request to</param>
        /// <returns></returns>
        public string SendDeleteRequestData(string url)
        {
            GetAuthToken();

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddHeader("authorization", "Bearer " + savedToken.access_Token);
            //request.AddHeader("Content-Type", "application/json");
            //request.AddParameter("application/json", ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);

            return response.Content;




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
