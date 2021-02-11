using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class Client
    {

        public static Logger logger = LogManager.GetCurrentClassLogger(); 
        public string client_id { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }

        public string active { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string registration_date { get; set; }

        public static Dictionary<string, string> clientDictionaryForDropdown = new Dictionary<string, string>();

        public static List<Client> listOfClients = new List<Client>();

        public static List<Workout> listOfClientWorkouts = new List<Workout>();

        /// <summary>
        /// Constructor
        /// </summary>
        public Client (string clientId, string fName, string lName, string userActive, string userAddress, string userCity, string userState, string userZipcode, string userPhone, string userEmail, string userRegDate)
        {
            client_id = clientId;
            firstName = fName;
            lastName = lName;
            active = userActive;
            address = userAddress;
            city = userCity;
            state = userState;
            zipcode = userZipcode;
            phone = userPhone;
            email = userEmail;
            registration_date = userRegDate;
        }
        
        /// <summary>
        /// Used or updating a client's data
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="userActive"></param>
        /// <param name="userAddress"></param>
        /// <param name="userCity"></param>
        /// <param name="userState"></param>
        /// <param name="userZipcode"></param>
        /// <param name="userPhone"></param>
        /// <param name="userEmail"></param>
        public Client(string clientId, string fName, string lName, string userActive, string userAddress, string userCity, string userState, string userZipcode, string userPhone, string userEmail)
        {
            client_id = clientId;
            firstName = fName;
            lastName = lName;
            active = userActive;
            address = userAddress;
            city = userCity;
            state = userState;
            zipcode = userZipcode;
            phone = userPhone;
            email = userEmail;
        }

        /// <summary>
        /// Gets client information from the API
        /// </summary>
        public static void GetClients()
        {
            clientDictionaryForDropdown.Add("0", "Choose Client");
            APIRequests request = new APIRequests();

            string response = request.GetWebsiteData(request.allClientDetailsEndpoint);

            ParseWebResponse(response);

        }

        /// <summary>
        /// Parses the web request
        /// </summary>
        /// <param name="response">JSON string that needs to be parsed.</param>
        public static void ParseWebResponse(string response)
        {

            if (response == "")
            {
                // TODO: Handle this case
            }
            else {
                // Try something else
                var doc = JsonDocument.Parse(response);
                JsonElement root = doc.RootElement;

                //var groups = root.EnumerateArray();

                //var u1 = root[0];
                //var u2 = root[1];

                for (int i = 0; i < root.GetArrayLength(); i++)
                {
                    // Get data for the dropdown list
                    string clientId = root[i].GetProperty("client_id").ToString();
                    string name = $"{root[i].GetProperty("firstname").ToString()} {root[i].GetProperty("lastname").ToString()}";

                    string firstName = root[i].GetProperty("firstname").ToString();
                    string lastName = root[i].GetProperty("lastname").ToString();
                    string active = root[i].GetProperty("active").ToString();
                    string address = root[i].GetProperty("streetaddress").ToString();
                    string city = root[i].GetProperty("city").ToString();
                    string state = root[i].GetProperty("state").ToString();
                    string zipCode = root[i].GetProperty("zipcode").ToString();
                    string phone = root[i].GetProperty("phone").ToString();
                    string email = root[i].GetProperty("email").ToString();

                    DateTime regDate = DateTime.Parse(root[i].GetProperty("registrationdate").ToString());
                    string registrationDate = regDate.Date.ToString("MM-dd-yyyy");

                    // Add client info to the dropdown list
                    clientDictionaryForDropdown.Add(clientId, name);

                    // Add client to the list
                    Client person = new Client(clientId, firstName, lastName, active, address, city, state, zipCode, phone, email, registrationDate);

                    listOfClients.Add(person);

                }
            }
            

        }

        public static void GetClientTrainingSessions(int clientId)
        {
            APIRequests request = new APIRequests();

            // Use the singleClientDetailEndpoint endpoint, and append {id}/trainingsessions to the URL
            string url = $"{request.singleClientDetailEndpoint}{clientId}/trainingsessions";

            var response = request.GetWebsiteData(url);

            TrainingSession.ParseTrainingSessionData(response);

        }

        public static void GetWorkoutHistory(int clientId)
        {
            Workout.GetWorkoutHistoryForClient(clientId);
            
        }

    } // end of class

}