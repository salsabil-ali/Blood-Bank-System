using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using BloodBankManagmentSystem.Models;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public class DonorDAL
    {
        // Handles database operations for Donor entities including CRUD and search.
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
                        Donor donor = new Donor
                        {
                            Donor_ID = Convert.ToInt32(reader["Donor_ID"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Date_of_Birth = Convert.ToDateTime(reader["Date_of_Birth"]),
                            Blood_Type = reader["Blood_Type"].ToString(),
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Address = reader["Address"].ToString()
                        };

                        donorList.Add(donor);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error fetching donors: " + ex.Message);
                }
            }

            return donorList;
        }


        // Adds a new donor to the Donor table using the AddDonor stored procedure.
        public void AddDonor(Donor donor)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("AddDonor", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

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


        // Updates an existing donor record using the UpdateDonor0 stored procedure.
        public void UpdateDonor(Donor donor)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UpdateDonor0", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Must match your CREATE PROCEDURE exactly:
                cmd.Parameters.AddWithValue("@Donor_ID", donor.Donor_ID);
                cmd.Parameters.AddWithValue("@Name", donor.Name);
                cmd.Parameters.AddWithValue("@Phone_Number", donor.Phone_Number);
                cmd.Parameters.AddWithValue("@Address", donor.Address);
                cmd.Parameters.AddWithValue("@Dgen", donor.Gender); // Added this

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        

        // Deletes a donor by ID using the DeleteDonor stored procedure.
        public void DeleteDonor(int donorId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("DeleteDonor", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Donor_ID", donorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Clears a donor's non-key fields by calling the ClearDonor stored procedure.
        public void ClearDonor(int donorId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ClearDonor", conn);

                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id", donorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Searches for a donor by ID using 'searchByDID' stored procedure and returns the Donor model.
        public Donor SearchDonor(int donorId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("searchByDID", conn); // Matches your SQL script name
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", donorId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Donor
                        {
                            Donor_ID = Convert.ToInt32(reader["Donor_ID"]),
                            Name = reader["Name"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            Date_of_Birth = Convert.ToDateTime(reader["Date_of_Birth"]),
                            Blood_Type = reader["Blood_Type"].ToString(),
                            Phone_Number = reader["Phone_Number"].ToString(),
                            Address = reader["Address"].ToString()
                        };
                    }
                }
            }
            return null;
        }
    }
}