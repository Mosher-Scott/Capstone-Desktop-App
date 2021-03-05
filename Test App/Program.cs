using System.Configuration;
using System;
using Exercise_Tracker.Classes;
using Newtonsoft.Json.Schema;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.Json;
using System.Collections.Generic;

namespace Test_App
{
    class Program
    {

        public static List<Car> garage = new List<Car>();

        static void Main(string[] args)
        {

            //stuff();
            //testEndpoint();
            //Workouts();

            //CarAssignment();

            misc();
        }

        public static void misc()
        {
            Console.WriteLine("Hi Ryane, now to look at loops");

            for(var i = 0; i < 100; i++)
            {
                if (i == 56)
                {
                    Console.WriteLine("Time to take a break, the stomach is full");
                } else
                {
                    Console.WriteLine($"Ryane ate {i} pieces of bacon for breakfast");
                }
                
            }

            Console.WriteLine("Ryane ate too much bacon, and threw up");
        }

        public static void CarAssignment()
        {
            Console.WriteLine("Adding a new car with the following attributes: Nickname - Old Faithful. Color - green, Type - suv, Maker - Jeep, Year made - 1996");
            Car car1 = new Car("Old Faithful", "green", "suv", "Jeep", 1996);

            Console.WriteLine("Congrats! You just got a new car!");

            garage.Add(car1);
            Console.WriteLine("You've added car 1 to your garage");

            Car car2 = new Car("Mid Life Crisis", "red", "sports car", "Ferrari", 2005);

            Console.WriteLine("Adding a new car with the following attributes: Nickname - Mid Life Crisis. Color - red, Type - sports car, Maker - Ferrari, Year made - 2005");

            garage.Add(car2);
            Console.WriteLine("You've added car 2 to your garage");

            Console.WriteLine(" ");
            Console.WriteLine("What can you do with your cars?");

            Console.WriteLine(" ");
            Console.WriteLine("Get a summary of your car");
            car1.CarSummary();
            car2.CarSummary();

            Console.WriteLine(" ");
            Console.WriteLine("Now use your cars!");
            car1.MoveForward();
            car2.MoveForward();
            car2.Brake();

            car2.Crash();


        }

        public static void testEndpoint()
        {
            Console.WriteLine("Now checking endpoint");
            APIRequests token = new APIRequests();

            string jsonData = token.GetRequests("https://frozen-meadow-69055.herokuapp.com/clients/1/workouthistory");


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
