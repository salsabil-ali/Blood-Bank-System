using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace BloodBankSystem.DataAccessLayer
{
    public static class DBConnection
    {
        // This line grabs the string where put in App.config
        private static string connString = ConfigurationManager.ConnectionStrings["BloodBankDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connString);
        }
    }
}