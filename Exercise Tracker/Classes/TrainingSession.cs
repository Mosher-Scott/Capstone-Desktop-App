using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Newtonsoft.Json;
using NLog;

namespace Exercise_Tracker.Classes
{
    public class TrainingSession
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public string sessionId { get; set; }
        public string sessionName { get; set; }
        public string sessionDescription { get; set; }
        public string sessionSets { get; set; }
        public string sessionReps { get; set; }
        public string active { get; set; }

        public static List<TrainingSession> listOfTrainingSessions = new List<TrainingSession>();

        public static List<TrainingSession> listOfAllTrainingSessions = new List<TrainingSession>();


        public static Dictionary<string, string> trainingSessionDictionaryForDropdown = new Dictionary<string, string>();


        public TrainingSession(string id, string name, string description, string sets, string reps, string active)
        {
            sessionId = id;
            sessionName = name;
            sessionDescription = description;
            sessionSets = sets;
            sessionReps = reps;
            this.active = active;
        }

        public static void GetAllTrainingSessions()
        {
            APIRequests request = new APIRequests();

            trainingSessionDictionaryForDropdown.Add("0", "Choose Training Session");

            string response = request.GetRequests(request.allTrainingSessionsEndpoint);

            ParseWebResponseToAddToDictionary(response);
        }

        private static void ParseWebResponseToAddToDictionary(string response)
        {
            dynamic trainingSessions = JsonConvert.DeserializeObject(response);

            if (trainingSessions is null)
            {

            } else
            {
                // logger.Info(trainingSessions);
                // TODO: Handle different responses

                // Loop through each workout, such as id, name, description, etc
                foreach (var item in trainingSessions)
                {
                    // Training Session Details
                    //logger.Info(item);
                    string id = item["session_id"].ToString();
                    string name = item["sessionname"].ToString();
                    string description = item["sessiondescription"].ToString();
                    string reps = item["sessionsets"].ToString();
                    string sets = item["sessionreps"].ToString();
                    string active = item["active"].ToString();

                    TrainingSession trainingSession = new TrainingSession(id, name, description, sets, reps, active);

                    TrainingSession.listOfAllTrainingSessions.Add(trainingSession);


                    // Add names and ID's to the dropdown list
                    TrainingSession.trainingSessionDictionaryForDropdown.Add(id, name);
                }
            
            }

        }

        /// <summary>
        /// Takes a list of training sesions in JSON format, and parses into individual sessions, and adds each to a list
        /// </summary>
        /// <param name="jsondata">A list of training sessions in JSON format</param>
        public static void ParseTrainingSessionData(string jsondata)
        {
            // logger.Info(jsondata);

            var doc = JsonDocument.Parse(jsondata);
            JsonElement root = doc.RootElement;

            //var thing1 = root[0];

            for (int i = 0; i < root.GetArrayLength(); i++)
            {

                string id = root[i].GetProperty("id").ToString();
                string sessionName = root[i].GetProperty("sessionname").ToString();
                string sessionDescription = root[i].GetProperty("sessiondescription").ToString();
                string sessionSets = root[i].GetProperty("sessionsets").ToString();
                string sessionReps = root[i].GetProperty("sessionreps").ToString();
                string active = root[i].GetProperty("active").ToString();

                TrainingSession trainingSession = new TrainingSession(id, sessionName, sessionDescription, sessionSets, sessionReps, active);

                listOfTrainingSessions.Add(trainingSession);
            }
        }


    } // End of class
}
