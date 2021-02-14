using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    class WorkoutHistoryExercises
    {
        public string name { get; set; }
        public string sets { get; set; }
        public string reps { get; set; }
        public string weight { get; set; }
        public string seconds { get; set; }

        public static List<WorkoutHistoryExercises> exercises = new List<WorkoutHistoryExercises>();

        public WorkoutHistoryExercises(string exerciseName, string exerciseSets, string exerciseReps, string exerciseWeight, string exerciseSeconds)
        {
            name = exerciseName;
            sets = exerciseSets;
            reps = exerciseReps;
            weight = exerciseWeight;
            seconds = exerciseSeconds;
        }
    }
}
