using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BloodBankManagmentSystem.Models;
using System.Data;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public class DonorDAL
    {
        public List<Donor> GetAllDonors()
        {
            List<Donor> donorList = new List<Donor>();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Donor";
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Use a helper method or inline checks to handle NULLs
                        donorList.Add(MapDonor(reader));
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching donors: " + ex.Message);
                }
            }
            return donorList;
        }

        public void AddDonor(Donor donor)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("AddDonor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Donor_ID", donor.Donor_ID);
                cmd.Parameters.AddWithValue("@Name", donor.Name);
                cmd.Parameters.AddWithValue("@Gender", donor.Gender);
                cmd.Parameters.AddWithValue("@Date_of_Birth", donor.Date_of_Birth);
                cmd.Parameters.AddWithValue("@Blood_Type", donor.Blood_Type);
                cmd.Parameters.AddWithValue("@Phone_Number", donor.Phone_Number);
                cmd.Parameters.AddWithValue("@Address", donor.Address);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateDonor(Donor donor)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UpdateDonor0", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Donor_ID", donor.Donor_ID);
                cmd.Parameters.AddWithValue("@Name", donor.Name);
                cmd.Parameters.AddWithValue("@Phone_Number", donor.Phone_Number);
                cmd.Parameters.AddWithValue("@Address", donor.Address);
                cmd.Parameters.AddWithValue("@Dgen", donor.Gender);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteDonor(int donorId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DeleteDonor", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Donor_ID", donorId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void ClearDonor(int donorId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ClearDonor0", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", donorId);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Donor SearchDonor(int donorId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("searchByDID", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", donorId);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return MapDonor(reader);
                    }
                }
            }
            return null;
        }

        // HELPER METHOD: This prevents the DBNull cast error
        private Donor MapDonor(SqlDataReader reader)
        {
            return new Donor
            {
                Donor_ID = Convert.ToInt32(reader["Donor_ID"]),
                // If Name is NULL in DB, use empty string instead of crashing
                Name = reader["Name"] == DBNull.Value ? "" : reader["Name"].ToString(),
                Gender = reader["Gender"] == DBNull.Value ? "" : reader["Gender"].ToString(),
                Blood_Type = reader["Blood_Type"] == DBNull.Value ? "" : reader["Blood_Type"].ToString(),
                Phone_Number = reader["Phone_Number"] == DBNull.Value ? "" : reader["Phone_Number"].ToString(),
                Address = reader["Address"] == DBNull.Value ? "" : reader["Address"].ToString(),
                // Handle Date specifically
                Date_of_Birth = reader["Date_of_Birth"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["Date_of_Birth"])
            };
        }
    }
}