using NLog;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class Exercise
    {
        public string name;
        public int muscleGroup;
        public string instructions;

        public static Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Holds info for a new exercise
        /// </summary>
        /// <param name="userName">Name of the exercise</param>
        /// <param name="userMuscleGroup">ID of the associated muscle group</param>
        /// <param name="userInstructions">Instructions for the exercise</param>
        public Exercise(string userName, int userMuscleGroup, string userInstructions)
        {
            name = userName;
            muscleGroup = userMuscleGroup;
            instructions = userInstructions;
        }


        public int InsertIntoDatabase()
        {
            var query = "";

            try
            {
                SqlConnection connection = DatabaseConnection.ConnectToDatabase();

                query = @"USE exercise_tracker INSERT INTO exercises (name, muscleGroup, instruction) VALUES (@name, @muscleGroup, @instructions); SELECT CAST(scope_identity() AS int)";

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@name", this.name);
                command.Parameters.AddWithValue("@muscleGroup", this.muscleGroup);
                command.Parameters.AddWithValue("@instructions", this.instructions);

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

    } // End of class
}
