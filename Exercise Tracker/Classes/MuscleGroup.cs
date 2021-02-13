using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;

namespace Exercise_Tracker.Classes
{
    class MuscleGroup
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        [JsonProperty("id")]
        public int id {get; set;}
        public string muscle_group_details { get; set; }

        public static  Dictionary<string, string> muscleGroupDictionary = new Dictionary<string, string>();


        public void SetItem(int idFromJson, string nameFromJson)
        {
            id = idFromJson;
            muscle_group_details = nameFromJson;
        }

        /// <summary>
        /// Creates and gets information from the muscle group endpoint.  Then calls ParseWebResponse() to clean them
        /// </summary>
        public static void GetMusclegroups()
        {
            muscleGroupDictionary.Add("0", "Choose Muscle Group");
            APIRequests request = new APIRequests();

            string response = request.GetRequests(request.allMuscleGroupsEndpoint);

            ParseWebResponse(response);

        }

        /// <summary>
        /// Parses the response from the API about the muscle groups
        /// </summary>
        /// <param name="response">Response from the HTTP request as a JSON string</param>
        public static void ParseWebResponse(string response)
        {

            if (response == "")
            {
                // TODO: Handle this case
            } else
            {
                // Try something else
                var doc = JsonDocument.Parse(response);
                JsonElement root = doc.RootElement;

                var groups = root.EnumerateArray();

                var u1 = root[0];
                var u2 = root[1];

                for (int i = 0; i < root.GetArrayLength(); i++)
                {
                    string itemId = root[i].GetProperty("id").ToString();
                    string name = root[i].GetProperty("muscle_group_details").ToString();

                    muscleGroupDictionary.Add(itemId, name);
                }
            }
            

        }

    } // End of class


}
