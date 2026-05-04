using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public static class DBConnection
    {
        // This line grabs the string where put in App.config
        private static string connString = ConfigurationManager.ConnectionStrings["HemoGlobeDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}