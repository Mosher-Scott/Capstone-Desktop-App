using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public class AddClientResponse
    {
        public string success { get; set; }
        public string data { get; set; }
        public string clientId { get; set; }


        public AddClientResponse(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jClient = jObject["AddClientResponse"];
            success = (string)jObject["success"];
            data = (string)jObject["data"];
            clientId = (string)jObject["clientId"];
        }
    }
}
