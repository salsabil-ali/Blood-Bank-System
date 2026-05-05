using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodBankManagmentSystem.Models;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    internal class BloodUnitDAL
    {
        public List<BloodUnit> GetAvailableBloodUnits(string bloodType)
        {
            List<BloodUnit> availableUnits = new List<BloodUnit>();
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("GetAvailableBloodUnits", conn)
                {
                    CommandType = CommandType.StoredProcedure

                };
                cmd.Parameters.Add("@Blood_Type", SqlDbType.NVarChar, 5).Value = bloodType;

                // Select statement is used, so ExecuteReader is needed here instead of ExecuteNonQuery
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    // Display available blood units, not really needed but could be useful for debugging
                    Console.WriteLine(reader["BloodUnit_ID"] + " - " + reader["Blood_Type"]);
                    BloodUnit unit = new BloodUnit
                    {
                        BloodUnit_ID = Convert.ToInt32(reader["BloodUnit_ID"]),
                        Blood_Type = reader["Blood_Type"]?.ToString() ?? "",
                        Collection_Date = Convert.ToDateTime(reader["Collection_Date"]),
                        Expiration_Date = Convert.ToDateTime(reader["Expiration_Date"]),
                        Status = reader["Status"]?.ToString() ?? "",
                        Donation_ID = Convert.ToInt32(reader["Donation_ID"])

                    };
                    availableUnits.Add(unit);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error adding blood unit: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return availableUnits;
        }


        public void UpdateBloodUnitStatus(int id, string status) // can be changed to take an object instead of individual parameters if needed
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("UpdateBloodUnitStatus", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("@BloodUnitID", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = status;

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new Exception("No record found with the given BloodUnitID.");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Error updating blood unit status: ", ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public int CountAvailableUnits(string bloodType)
        {
            int count = 0;
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("CountAvailableUnits", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@Blood_Type", SqlDbType.NVarChar, 5).Value = bloodType;
                object result = cmd.ExecuteScalar();
                count = result == null ? 0 : Convert.ToInt32(result);

            }
            catch (Exception ex)
            {
                throw new Exception("Error counting available blood units: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return count;
        }

    }
}
