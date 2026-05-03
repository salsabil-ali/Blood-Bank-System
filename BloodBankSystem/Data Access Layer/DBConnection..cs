using System.Data.SqlClient;
using System.Configuration;

namespace  BloodBankSystem.DataAccessLayer
{
    public class DBConnection
    {
        // This pulls the string from  App.config file
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["HemoGlobeDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}