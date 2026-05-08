using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public static class DBConnection
    {
        // Provides a centralized method to obtain a SqlConnection using the 'BloodBankConn' connection string (The string that was put in App.config.
        private static string connString = ConfigurationManager.ConnectionStrings["BloodBankConn"].ConnectionString;

        // Returns a new SqlConnection instance using the configured connection string.
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}