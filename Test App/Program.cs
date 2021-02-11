using System.Configuration;
using System;
using Exercise_Tracker.Classes;
using Newtonsoft.Json.Schema;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {

            //stuff();
            //testEndpoint();
            Workouts();
        }

        public static void testEndpoint()
        {
            Console.WriteLine("Now checking endpoint");
            APIRequests token = new APIRequests();

            string jsonData = token.GetWebsiteData("https://frozen-meadow-69055.herokuapp.com/clients/1/workouthistory");


            try
            {
                JArray jsonArray = JArray.Parse(jsonData);
                Console.WriteLine("jarray count: " + jsonArray.Count);
                
                Console.WriteLine(jsonArray);

                for (int i = 0; i < jsonArray.Count; i++)
                {
                    JObject data = JObject.Parse(jsonArray[i].ToString());

                    //Client client = data.ToObject<Client>();

                    //TrainingSessions trainingSessions = JObject.Parse(jsonArray[i].ToString())

                    //Console.WriteLine("\nNow writing a random value");
                    //Console.WriteLine("State: " + client.state);
                    //Console.WriteLine("First Name: " + client.firstName);
                    // Console.WriteLine("Trainingsession: " + client.assigned_training_sessions);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                Console.WriteLine(jsonData);
                return;
            }

            //// Option #2
            //JArray array = JArray.Parse(jsonData);
            //foreach (JObject obj in array.Children<JObject>())
            //{

            //    foreach (JProperty singleProp in obj.Properties())
            //    {
            //        string name = singleProp.Name;
            //        string value = singleProp.Value.ToString();
            //        Console.WriteLine("Name: " + name + "\nValue: " + value);
            //        //Do something with name and value
            //        //System.Windows.MessageBox.Show("name is "+name+" and value is "+value);
            //    }
            //}

        }

        public static void stuff()
        {
            string clientId = "nxX9bmKfRHIYQm8ed9rgHLyuxKCDGfkJ";

            string clientSecret = "14jeDljEsFy0P8Jnam8M0fQIOByPjNZu-KDoKFTG6lL1c5GsRFG74E9q8Y8qnY4f";

            var item = "application/json" + "{\"client_id\":\"nxX9bmKfRHIYQm8ed9rgHLyuxKCDGfkJ\",\"client_secret\":\"14jeDljEsFy0P8Jnam8M0fQIOByPjNZu-KDoKFTG6lL1c5GsRFG74E9q8Y8qnY4f\",\"audience\":\"https://capstone-api-auth\",\"grant_type\":\"client_credentials\"}";
            Console.Write(item);

            string body = "application/json" + "{\"client_id\":\"" + clientId + "\",\"client_secret\":\"" + clientSecret + "\",\"audience\":\"https://capstone-api-auth\",\"grant_type\":\"client_credentials\"}";

            Console.WriteLine(" ");

            Console.WriteLine(body);
        }

        public static void Workouts()
        {
            Workout.GetWorkoutHistoryForClient(1);
        }
    }
}
