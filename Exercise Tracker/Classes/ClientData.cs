using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MyClasses;
using System.Threading.Tasks;
using NLog;

namespace Exercise_Tracker.Classes
{
    class ClientData
    {
        public int clientId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static DataTable clientDataResultsTable = new DataTable();
        public static DataTable clientTrainingSessionsTable = new DataTable();
        public static DataTable sessionExercisesTable = new DataTable();
        public static DataTable recordingExercisesTable = new DataTable();

        public static Dictionary<int, string> clients = new Dictionary<int, string>();

        #region Queries
        private static string GenerateClientInfoQuery(int id)
        {
            return $@"USE exercise_tracker SELECT c.id AS [ID], c.firstName AS [First Name], c.lastName AS [Last Name], 
                            ci.streetAddress AS [Address], ci.city AS [City], ci.state AS [State], 
                            ci.zipcode AS [Zipcode], ci.email AS [Email], ci.phone AS [Phone] 
                            FROM client AS c 
                            JOIN client_info AS ci ON ci.clientId = c.id 
                            WHERE c.id = {id}";
        }

        private static string GenerateClientTrainingSessionQuery(int id)
        {
            return $@"USE exercise_tracker SELECT ts.id, ts.SessionName AS [Name], ts.sessionDescription AS [Description], ts.sessionSets AS [Sets], ts.sessionReps AS [Reps]
                            FROM client_training_session AS cts
                            JOIN training_session AS ts ON ts.id = cts.sessionId
                            WHERE cts.clientId = {id};";
        }

        private static string GenerateTrainingSessionExercisesQuery(int id)
        {
            return $@"USE exercise_tracker SELECT e.name AS[Name], e.instruction AS[Instructions]
                            FROM exercises AS e
                            JOIN session_exercises AS se ON se.exerciseId = e.id
                            WHERE se.sessionId = {id}; ";
        }

        private static string GenerateExerciseListNameQuery(int id)
        {
            return $@"USE exercis_tracker SELECT e.name AS [Name]
                    FROM exercises AS e
                    JOIN session_exercises AS se ON se.exerciseId = e.id
                    WHERE se.sessionId = {id}";
        }

        private static string GenerateExerciseListForRecordingQuery(int id)
        {
            return $@"USE exercise_tracker
                    SELECT e.id AS [ID], e.name AS [Name], '' AS [Sets], '' AS [Reps], '' AS [Weight], '' AS [Time]
                    FROM exercises AS e
                    JOIN session_exercises AS se ON se.exerciseId = e.id
                    WHERE se.sessionId = 1;";
        }
        #endregion


        public static SqlConnection ConnectToDatabase()
        {
            string connectionString = ConfigurationManager.AppSettings.Get("DbConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }

        /// <summary>
        /// Gets information from the database, and populates a datatable with the results
        /// </summary>
        /// <param name="infoNeeded">ClientInfo, ClientTrainingSessions, GetTrainingSessionExercises, RecordWorkout</param>
        /// <param name="id">Id needed for the query. Optional</param>
        public static void GetDataFromDatabase(string infoNeeded, int id = 0)
        {
            string query = "";
            DataTable tableToModify = new DataTable();
            switch (infoNeeded)
            {
                case "ClientInfo":
                    query = GenerateClientInfoQuery(id);
                    clientDataResultsTable.Clear();
                    tableToModify = clientDataResultsTable;
                    break;
                case "ClientTrainingSessions":
                    query = GenerateClientTrainingSessionQuery(id);
                    clientTrainingSessionsTable.Clear();
                    tableToModify = clientTrainingSessionsTable;
                    break;
                case "GetTrainingSessionExercises":
                    query = GenerateTrainingSessionExercisesQuery(id);
                    sessionExercisesTable.Clear();
                    tableToModify = sessionExercisesTable;
                    break;

                case "RecordWorkout":
                    query = GenerateExerciseListForRecordingQuery(id);
                    recordingExercisesTable.Clear();
                    tableToModify = recordingExercisesTable;
                    break;

            }

            SqlConnection connection = ConnectToDatabase();

            try
            {

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandTimeout = 220;

                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter(command);

                da.Fill(tableToModify);
                connection.Close();
                da.Dispose();
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }

        }

        
        // Populates a list of all clients in the database
        public static void GetAllClients()
        {
            var query = "";

            try
            {
                // SqliteConnection dataDbConnection = Db3File.ConnectToNonObjectDb3File(FormMainMenu.dataDbName);

                SqlConnection connection = ConnectToDatabase();

                query = "USE exercise_tracker SELECT id, firstName, lastName FROM dbo.client";
                //query = "SELECT * FROM exercises";

                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (var reader = command.ExecuteReader())
                    {
                        var list = new List<ClientData>();
                        while (reader.Read())
                            ClientData.clients.Add(reader.GetInt32(0), $"{reader.GetString(1)} {reader.GetString(2)}");
                        logger.Info(reader.GetString(1));

                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Error selecting data: {ex.Message}");
                
            }

        }


    } // end of class
}
