using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BloodBankManagmentSystem.Models;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public class DonorDAL
    {
        // =========================
        // GET ALL
        // =========================
        public List<Donor> GetAllDonors()
        {
            List<Donor> donors = new List<Donor>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("GetAllDonors", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Donor d = new Donor
                    {
                        Donor_ID = Convert.ToInt32(reader["Donor_ID"]),
                        Name = reader["Name"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Date_of_Birth = Convert.ToDateTime(reader["Date_of_Birth"]),
                        Blood_Type = reader["Blood_Type"].ToString(),
                        Phone_Number = reader["Phone_Number"].ToString(),
                        Address = reader["Address"].ToString()
                    };

                    donors.Add(d);
                }
            }

            return donors;
        }

        // =========================
        // INSERT
        // =========================
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

        // =========================
        // UPDATE
        // =========================
        public void UpdateDonor(Donor donor)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("UpdateDonor", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Donor_ID", donor.Donor_ID);
                cmd.Parameters.AddWithValue("@Name", donor.Name);
                cmd.Parameters.AddWithValue("@Phone_Number", donor.Phone_Number);
                cmd.Parameters.AddWithValue("@Address", donor.Address);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // =========================
        // DELETE
        // =========================
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

        // =========================
        // CLEAR (NULL values)
        // =========================
        public void ClearDonor(int donorId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                SqlCommand cmd = new SqlCommand("ClearDonor", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Donor_ID", donorId);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}