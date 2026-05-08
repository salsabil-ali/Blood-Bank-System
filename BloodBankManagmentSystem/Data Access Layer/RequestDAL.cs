using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BloodBankManagmentSystem.Models;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public class RequestDAL
    {
        // Data access for BloodRequest entities: provides retrieval and CRUD operations.
        // Retrieves all blood requests for display in grids or UI lists.
        public List<BloodRequest> GetAllRequests()
        {
            List<BloodRequest> requests = new List<BloodRequest>();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetAllRequests", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    requests.Add(new BloodRequest
                    {
                        Request_ID = Convert.ToInt32(reader["Request_ID"]),
                        Request_Date = Convert.ToDateTime(reader["Request_Date"]),
                        Blood_Type = reader["Blood_Type"].ToString(),
                        Quantity_Requested = Convert.ToInt32(reader["Quantity_Requested"]),
                        Status = reader["Request_Status"].ToString(),
                        Hospital_ID = Convert.ToInt32(reader["Hospital_ID"])
                    });
                }
            }
            return requests;
        }

        // Retrieves request details (allocated blood units) for a specific request ID.
        public List<RequestDetails> GetRequestDetails(int requestId)
        {
            List<RequestDetails> list = new List<RequestDetails>();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "SELECT Request_ID, BloodUnit_ID, Quantity_Allocated FROM Request_Details WHERE Request_ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", requestId);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new RequestDetails
                    {
                        Request_ID = (int)reader["Request_ID"],
                        BloodUnit_ID = (int)reader["BloodUnit_ID"],
                        Quantity_Allocated = (int)reader["Quantity_Allocated"]
                    });
                }
            }
            return list;
        }

        // Adds a new blood request using the provided BloodRequest model.
        public void AddBloodRequest(BloodRequest req)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("AddBloodRequest", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Request_ID", req.Request_ID);
                cmd.Parameters.AddWithValue("@Request_Date", req.Request_Date);
                cmd.Parameters.AddWithValue("@Blood_Type", req.Blood_Type);
                cmd.Parameters.AddWithValue("@Quantity_Requested", req.Quantity_Requested);
                cmd.Parameters.AddWithValue("@Hospital_ID", req.Hospital_ID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Updates the status of a specific blood request by ID.
        public void UpdateRequestStatus(int id, string status)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "UPDATE Blood_Request SET Request_Status = @status WHERE Request_ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Deletes a blood request by calling the 'DeleteRequest' stored procedure.
        public void DeleteRequest(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                // 1. MUST match the SQL name exactly
                SqlCommand cmd = new SqlCommand("DeleteRequest", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // 2. MUST match the variable name in your SQL (@Id)
                cmd.Parameters.AddWithValue("@Id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Searches for a BloodRequest by ID and returns the model if found.
        public BloodRequest SearchByRequestID(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "SELECT * FROM Blood_Request WHERE Request_ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new BloodRequest
                    {
                        Request_ID = (int)reader["Request_ID"],
                        Request_Date = (DateTime)reader["Request_Date"],
                        Blood_Type = reader["Blood_Type"].ToString(),
                        Quantity_Requested = (int)reader["Quantity_Requested"],
                        Status = reader["Request_Status"].ToString(),
                        Hospital_ID = (int)reader["Hospital_ID"]
                    };
                }
            }
            return null;
        }
    }
}