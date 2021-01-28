using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Tracker.Classes
{
    public static class DatabaseConnection
    {
        public static SqlConnection ConnectToDatabase()
        {
            string connectionString = ConfigurationManager.AppSettings.Get("DbConnectionString");
            SqlConnection connection = new SqlConnection(connectionString);

            return connection;
        }
    }
}
