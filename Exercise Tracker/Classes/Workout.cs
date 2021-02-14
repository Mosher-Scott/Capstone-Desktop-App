using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using NLog;
using System.IO;
using Newtonsoft.Json;

namespace Exercise_Tracker.Classes
{
    public class Workout
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public string workoutId { get; set; }
        public string sessionDate { get; set; }
        public string sessionName { get; set; }

        public static List<Workout> listOfWorkouts = new List<Workout>();

        public Workout(string id, string date, string name)
        {
            workoutId = id;
            sessionDate = date;
            sessionName = name;
        }

        
        /// <summary>
        /// Gets client information from the API
        /// </summary>
        public static void GetWorkoutHistoryForClient(int clientId)
        {
            //clientDictionaryForDropdown.Add("0", "Choose Client");
            APIRequests request = new APIRequests();

            string url = $"{request.singleClientDetailEndpoint}{clientId}/workouthistory";
            //logger.Debug(url);
            string response = request.GetRequests(url);

            ParseWebResponse(response);

        }

        /// <summary>
        /// Parses the web request
        /// </summary>
        /// <param name="response">JSON string that needs to be parsed.</param>
        public static void ParseWebResponse(string response)
        {
            if(response.Contains("No workout history found for client"))
            {

            } else
            {
                dynamic workouts = JsonConvert.DeserializeObject(response);


                // TODO: Handle different responses

                // Loop through each workout, such as id, name, description, etc
                foreach (var item in workouts)
                {
                    // Training Session Details
                    //logger.Info(item);
                    string id = item["workoutid"].ToString();
                    string date = item["sessiondate"].ToString();
                    string name = item["trainingsessionname"].ToString();

                    Workout workout = new Workout(id, date, name);

                    Workout.listOfWorkouts.Add(workout);

                    // Now loop through the workout_details array and parse the data
                    //foreach(var exercise in item["workout_details"])
                    //{
                    //    logger.Info(exercise.exercise_name);
                    //}
                    //logger.Info(item["exerciseDetails"]);
                }
            }

        }




    } // End of class
}
