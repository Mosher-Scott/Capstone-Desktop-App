using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class Exercise
    {
        public string exercise_id { get; set; }
        public string name { get; set; }
        public string muscle_group_name { get; set; }
        public string muscle_group_id { get; set; }
        public string instruction { get; set; }

        public string active { get; set; }

        public static Dictionary<string, string> exerciseListForDropdown = new Dictionary<string, string>();

        public static List<Exercise> exerciseList = new List<Exercise>();

        public static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Create an object based off of parsing JSON from the API
        /// </summary>
        /// <param name="userName">Name of the exercise</param>
        /// <param name="userMuscleGroup">ID of the associated muscle group</param>
        /// <param name="userInstructions">Instructions for the exercise</param>
        public Exercise(string exerciseId, string exerciseName, string exerciseMuscleGroupId, string exerciseMuscleGroupName,  string exerciseInstructions, string exerciseActive)
        {
            name = exerciseName;
            muscle_group_name = exerciseMuscleGroupName;
            muscle_group_id = exerciseMuscleGroupId;
            instruction = exerciseInstructions;
            exercise_id = exerciseId;
            active = exerciseActive;
        }

        /// <summary>
        /// Constructor for adding a new exerise to the database
        /// </summary>
        /// <param name="exerciseName">Nam of the exercise</param>
        /// <param name="exerciseMuscleId">Id of the muscle group</param>
        /// <param name="exerciseInstructions">Instructions for performing the exercise</param>
        /// <param name="exerciseActive">Is the exercise active or not</param>
        public Exercise(string exerciseName, string exerciseMuscleId, string exerciseInstructions, string exerciseActive)
        {
            name = exerciseName;
            muscle_group_id = exerciseMuscleId;
            instruction = exerciseInstructions;
            active = exerciseActive;
        }

        /// <summary>
        /// Insert a new exercise into the databse
        /// </summary>
        /// <returns>The ID of the exercise you just inserted into the database.  Returns -99 if there was an error</returns>
        public int InsertIntoDatabase()
        {
            var query = "";

            try
            {
                SqlConnection connection = DatabaseConnection.ConnectToDatabase();

                query = @"USE exercise_tracker INSERT INTO exercises (name, muscleGroupId, instruction, active) VALUES (@name, @muscleGroupId, @instructions, @active); SELECT CAST(scope_identity() AS int)";

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", this.name);
                command.Parameters.AddWithValue("@muscleGroupId", this.muscle_group_id);
                command.Parameters.AddWithValue("@instructions", this.instruction);
                command.Parameters.AddWithValue("@active", this.active);

                int lastInsertedId = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return lastInsertedId;
            }
            catch (Exception ex)
            {
                logger.Error("Error inserting exercise into database");
                logger.Error(ex.Message);
                
                return -99;
            }
        }

        public static void GetExercises()
        {
            exerciseListForDropdown.Add("0", "Choose Exercise");
            APIRequests request = new APIRequests();

            string response = request.GetWebsiteData(request.allExercisesEndpoint);

            ParseWebResponse(response);
        }

        /// <summary>
        /// Parses the response received from the API
        /// </summary>
        /// <param name="response">A string of JSON data</param>
        public static void ParseWebResponse(string response)
        {
            if(response == "")
            {
                // TODO: Handle this
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
                    string exerciseId = root[i].GetProperty("exercise_id").ToString();
                    string name = root[i].GetProperty("name").ToString();
                    string instruction = root[i].GetProperty("instruction").ToString();
                    string active = root[i].GetProperty("active").ToString();
                    string muscleGroupId = root[i].GetProperty("muscle_group_id").ToString();
                    string muscleGroupName = root[i].GetProperty("muscle_group_name").ToString();
                    //logger.Error($"{itemId}, {name}, {instruction}, {active}");

                    // Add to the dictionary to populate the dropdown lists
                    exerciseListForDropdown.Add(exerciseId, name);

                    // Create an Exercise, and add it to the list
                    Exercise newExercise = new Exercise(exerciseId, name, muscleGroupId, muscleGroupName, instruction, active);

                    exerciseList.Add(newExercise);

                }
            }
        }

    } // End of class
}
