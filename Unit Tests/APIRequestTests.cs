using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercise_Tracker;
using Exercise_Tracker.Classes;

namespace APIRequestTests
{
    [TestClass]
    public class APIRequestTests
    {
        /// <summary>
        /// Sets the environment to Live, goes to the auth service, and checks if the token is valid
        /// </summary>
        [TestMethod]
        public void T1000_Get_Valid_Auth_Token()
        {
            APIRequests.environment = APIRequests.liveEnvironment;

            APIRequests request = new APIRequests();
            
            request.GetAuthToken();

            string token = APIRequests.savedToken.access_Token.ToString();

            Assert.AreEqual(token, "hi");

        }
    }
}
