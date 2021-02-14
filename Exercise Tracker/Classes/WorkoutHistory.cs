using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class WorkoutHistory
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public string id { get; set; }
        public string sessionName { get; set; }
        public string sessionDescription { get; set; }

        public string sessionDate { get; set; }

        // Exercises
        

        public WorkoutHistory(string workoutId, string workoutName, string workoutDescription, string date)
        {
            id = workoutId;
            sessionName = workoutName;
            sessionDescription = workoutDescription;

            DateTime regDate = DateTime.Parse(date);

            sessionDate = regDate.Date.ToString("MM-dd-yyyy");

        }

        public static void GetWorkoutInformation(int id)
        {

        }

        #region DB Methods
        /// <summary>
        /// Inserts the cliendId and SessionId into the client_workout_history table
        /// </summary>
        /// <param name="clientId">clientId of the person</param>
        /// <param name="sessionId">sessionId that the user did</param>
        /// <returns></returns>
        public static int InsertSessionIntoDatabase(int clientId, int sessionId)
        {
            var query = "";

            try
            {
                SqlConnection connection = DatabaseConnection.ConnectToDatabase();

                query = @"USE exercise_tracker INSERT INTO client_workout_history (clientId, sessionId) VALUES (@clientId, @sessionId); SELECT CAST(scope_identity() AS int)";

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@clientId", clientId);
                command.Parameters.AddWithValue("@sessionId", sessionId);

                int lastInsertedId = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return lastInsertedId;
            }
            catch (Exception ex)
            {
                logger.Error("Error inserting data into client_workout_history");
                logger.Error(ex.Message);
                return -99;
            }
        }

        /// <summary>
        /// Inserts a row into the client_workout_history_exercises table
        /// </summary>
        /// <param name="workoutSessionId">ID of the workout session found in the client_workout_history table</param>
        /// <param name="exerciseId">Exercise ID of the exercise being inserted</param>
        /// <param name="sets">Number of sets the user performed</param>
        /// <param name="reps">Number of reps per set</param>
        /// <param name="weight">Weight used in each set (optional)</param>
        /// <param name="time">Time in seconds the user performed an exercise (optional)</param>
        /// <returns></returns>
        internal static int InsertExerciseIntoHistory(int workoutSessionId, int exerciseId, int sets, int reps, int weight, int time)
        {
            var query = "";

            try
            {
                SqlConnection connection = DatabaseConnection.ConnectToDatabase();

                query = @"USE exercise_tracker INSERT INTO client_workout_history_exercises (workoutHistoryId, exerciseId, sets, reps, weight, seconds) VALUES (@workoutSessionId, @exerciseId, @sets, @reps, @weight, @time);";

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@workoutSessionId", workoutSessionId);
                command.Parameters.AddWithValue("@exerciseId", exerciseId);
                command.Parameters.AddWithValue("@sets", sets);
                command.Parameters.AddWithValue("@reps", reps);
                command.Parameters.AddWithValue("@weight", weight);
                command.Parameters.AddWithValue("@time", time);

                int lastInsertedId = Convert.ToInt32(command.ExecuteScalar());

                connection.Close();

                return lastInsertedId;
            }
            catch (Exception ex)
            {
                logger.Error($"Error selecting data: {ex.Message}");
                return -99;
            }
        }

        #endregion

    } // End of class
}
