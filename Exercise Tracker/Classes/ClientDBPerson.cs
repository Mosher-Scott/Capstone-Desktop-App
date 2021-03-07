using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class ClientDBPerson
    {
        public string email;
        public string password;
        public int fitness_app_id;
        public string appId = "desktopApp";
        public string appSecret = "192837465";

        public ClientDBPerson(string clientEmail, string clientPassword, int id)
        {
            email = clientEmail;
            password = clientPassword;
            fitness_app_id = id;
        }
    }
}
