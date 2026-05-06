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
    internal class RequestDAL
    {
        public void AddBloodRequest(BloodRequest request) //hmm should make the parameters of the function as the properties of the request class?
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("AddBloodRequest", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("@Request_ID", SqlDbType.Int).Value = request.Request_ID;
                cmd.Parameters.Add("@Request_Date", SqlDbType.Date).Value = request.Request_Date;
                cmd.Parameters.Add("@Blood_Type", SqlDbType.NVarChar, 5).Value = request.Blood_Type;
                cmd.Parameters.Add("@Quantity_Requested", SqlDbType.Int).Value = request.Quantity_Requested;
                cmd.Parameters.Add("@Hospital_ID", SqlDbType.Int).Value = request.Hospital_ID;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding request: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateRequestStatus(int requestId, string newStatus)
        {
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateRequestStatus", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add("Id", SqlDbType.Int).Value = requestId;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = newStatus;

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected == 0)
                {
                    throw new Exception("No record found with the given Request_ID.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating request status: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public List<BloodRequest> GetAllRequests()
        {
            List<BloodRequest> requests = new List<BloodRequest>();
            SqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("GetAllRequests", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    BloodRequest request = new BloodRequest
                    {
                        Request_ID = Convert.ToInt32(reader["Request_ID"]),
                        Request_Date = Convert.ToDateTime(reader["Request_Date"]),
                        Blood_Type = reader["Blood_Type"]?.ToString() ?? "",
                        Quantity_Requested = Convert.ToInt32(reader["Quantity_Requested"]),
                        Request_Status = reader["Request_Status"]?.ToString() ?? "",
                        Hospital_ID = Convert.ToInt32(reader["Hospital_ID"])
                    };
                    requests.Add(request);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving blood requests: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return requests;
        }
    }
}
