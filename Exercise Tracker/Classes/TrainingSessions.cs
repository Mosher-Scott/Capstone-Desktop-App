using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class TrainingSessions
    {
        public string session_id { get; set; }
        public string sessionname { get; set; }
        public string sessiondescription { get; set; }
        public string sessionsets { get; set; }
        public string sessionreps { get; set; }
        public bool active { get; set; }

        Exercise[] exercise { get; set; }

    }
}
