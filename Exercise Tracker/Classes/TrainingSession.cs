using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
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

        public TrainingSession(string id, string name, string description, string sets, string reps, string active)
        {
            sessionId = id;
            sessionName = name;
            sessionDescription = description;
            sessionSets = sets;
            sessionReps = reps;
            this.active = active;
        }


        public static void ParseTrainingSessionData(string jsondata)
        {
            logger.Info(jsondata);

            var doc = JsonDocument.Parse(jsondata);
            JsonElement root = doc.RootElement;

            var thing1 = root[0];

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
