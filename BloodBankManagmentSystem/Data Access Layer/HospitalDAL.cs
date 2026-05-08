using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BloodBankManagmentSystem.Models;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    internal class HospitalDAL
    {
        public List<Hospital> GetAllHospitals()
        {
            List<Hospital> hospitals = new List<Hospital>();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetAllHospitals", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        hospitals.Add(new Hospital
                        {
                            Hospital_ID = Convert.ToInt32(reader["Hospital_ID"]),
                            Hospital_Name = reader["Hospital_Name"].ToString(),
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Address = reader["Address"].ToString()
                        });
                    }
                }
            }
            return hospitals;


        }
        public void AddHospital(Hospital h)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                
                string query = "INSERT INTO Hospital (Hospital_ID, Hospital_Name, Phone_Number, Address) VALUES (@id, @name, @phone, @address)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", h.Hospital_ID);
                cmd.Parameters.AddWithValue("@name", h.Hospital_Name);
                cmd.Parameters.AddWithValue("@phone", h.Phone_Number);
                cmd.Parameters.AddWithValue("@address", h.Address);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateHospital(Hospital h)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                
                string query = @"UPDATE Hospital 
                                 SET Hospital_Name = @name, 
                                     Phone_Number = @phone, 
                                     Address = @address 
                                 WHERE Hospital_ID = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", h.Hospital_ID);
                cmd.Parameters.AddWithValue("@name", h.Hospital_Name);
                cmd.Parameters.AddWithValue("@phone", h.Phone_Number);
                cmd.Parameters.AddWithValue("@address", h.Address);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                    throw new Exception("No hospital found with that ID to update.");
            }
        }

        // 2. Delete Hospital
        public void DeleteHospital(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Hospital WHERE Hospital_ID = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    
                    if (ex.Number == 547)
                        throw new Exception("Cannot delete this hospital because it has active blood requests.");

                    throw ex;
                }
            }
        }
        public Hospital GetHospitalById(int id)
        {
            Hospital hospital = null;
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("searchByHID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        hospital = new Hospital
                        {
                            Hospital_ID = Convert.ToInt32(reader["Hospital_ID"]),
                            Hospital_Name = reader["Hospital_Name"].ToString(),
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                    }
                }
            }
            return hospital;
        }

        public void ClearHospitalRecord(int id)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                // Calling your specific stored procedure
                SqlCommand cmd = new SqlCommand("ClearHospital", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Pass the ID and dummy values for the other params in your SQL
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@nam", DBNull.Value);
                cmd.Parameters.AddWithValue("@pno", DBNull.Value);
                cmd.Parameters.AddWithValue("@adds", DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}