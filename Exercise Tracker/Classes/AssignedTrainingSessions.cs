using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Exercise_Tracker.Classes
{
    class AssignedTrainingSessions
    {
        public int clientId;
        public int sessionId;
        

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static List<AssignedTrainingSessions> newTrainingSessionList = new List<AssignedTrainingSessions>();
        public static List<AssignedTrainingSessions> removedTrainingSessionList = new List<AssignedTrainingSessions>();

        public AssignedTrainingSessions(int clientIdToUse, int trainingSessionId)
        {
            clientId = clientIdToUse;
            sessionId = trainingSessionId;
        }

        /// <summary>
        /// Adding the new workouts to the database for the user
        /// </summary>
        public static void AddNewTrainingSessionsToDatabase()
        {
            // Change this to check all
            foreach(var item in AssignedTrainingSessions.newTrainingSessionList)
            {
                // Handle this differently, so if there is an error a flag will be raised
                //logger.Info($"clientId: {item.clientId}, sessionId: {item.sessionId}");
                APIRequests request = new APIRequests();

                string url = $"{request.singleClientDetailEndpoint}{item.clientId}/trainingsessions/{item.sessionId}";
                //logger.Info(url);

                var response = request.SendPostRequestData(url);

                //logger.Info(response);

            }
        }

        /// <summary>
        /// For removing training sessions that were assigned to the client, but have been removed
        /// </summary>
        public static void RemoveTrainingSessionsFromDatabase()
        {
            foreach(var item in AssignedTrainingSessions.removedTrainingSessionList)
            {
                
                // Handle this differently, so if there is an error a flag will be raised
                //logger.Info($"clientId: {item.clientId}, sessionId: {item.sessionId}");
                APIRequests request = new APIRequests();

                string url = $"{request.singleClientDetailEndpoint}{item.clientId}/trainingsessions/{item.sessionId}";

                var response = request.SendDeleteRequestData(url);

                //logger.Info(response);
            }


        }
    } // End of class
}
