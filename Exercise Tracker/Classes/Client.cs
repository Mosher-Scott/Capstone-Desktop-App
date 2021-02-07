using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class Client
    {
        public int client_id { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }

        public bool client_active_flag { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public DateTime registration_date { get; set; }

        public TrainingSessions[] assigned_training_sessions { get; set; } 

        public WorkoutHistory[] workoutHistory { get; set; }

    }

}