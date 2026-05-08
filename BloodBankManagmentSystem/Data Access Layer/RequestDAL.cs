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

        
     

        
            // Uses [GetAllRequests] procedure
            public List<BloodRequest> GetAllRequests()
            {
                List<BloodRequest> requests = new List<BloodRequest>();
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("GetAllRequests", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
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
                }
                return requests;
            }

            // Uses [searchByID] procedure
            public BloodRequest SearchByRequestID(int id)
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("searchByID", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
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
                }
                return null;
            }

            // Uses [DeleteRequest] procedure (Safe because it handles child table first)
            public void DeleteRequest(int id)
            {
                using (SqlConnection conn = DBConnection.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand("DeleteRequest", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        // Uses [UpdateRequestStatus] procedure
        public void UpdateHospitalRequest(BloodRequest req)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                // Use standard SQL UPDATE syntax for the Blood_Request table
                string query = @"UPDATE Blood_Request 
                         SET Request_Date = @date, 
                             Blood_Type = @type, 
                             Quantity_Requested = @qty, 
                             Hospital_ID = @hospId
                         WHERE Request_ID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@date", req.Request_Date);
                cmd.Parameters.AddWithValue("@type", req.Blood_Type);
                cmd.Parameters.AddWithValue("@qty", req.Quantity_Requested);
                cmd.Parameters.AddWithValue("@hospId", req.Hospital_ID);
                cmd.Parameters.AddWithValue("@id", req.Request_ID);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("Update Error: No request found with that ID to update.");
                }
            }
        }

        // Added this to fix error CS1061 seen in your screenshots
        public List<RequestDetails> GetRequestDetails(int requestId)
        {
            List<RequestDetails> list = new List<RequestDetails>();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string sql = "SELECT Request_ID, BloodUnit_ID, Quantity_Allocated FROM Request_Details WHERE Request_ID = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", requestId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
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
            }
            return list;
        }
    }
    
}