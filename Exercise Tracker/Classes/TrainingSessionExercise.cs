using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Exercise_Tracker.Classes
{
    public class TrainingSessionExercise
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();

        public static List<TrainingSessionExercise> trainingSessionExerciseList = new List<TrainingSessionExercise>();

        [DisplayName("ID")]
        public string id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Instructions")]
        public string instructions { get; set; }
        [DisplayName("Muscle Group")]
        public string muscleGroup { get; set; }

        public TrainingSessionExercise(string exerciseId, string exerciseName, string exerciseInstructions, string exerciseMuscleGroup)
        {
            id = exerciseId;
            name = exerciseName;
            instructions = exerciseInstructions;
            muscleGroup = exerciseMuscleGroup;
        }

    }
}
