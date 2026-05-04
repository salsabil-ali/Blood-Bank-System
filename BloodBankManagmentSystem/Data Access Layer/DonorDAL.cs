using System;
using System.Collections.Generic;
using System.Data.SqlClient; 
using System.Data;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public class DonorDAL
    {
        public List<Donor> GetAllDonors()
        {
            List<Donor> donorList = new List<Donor>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Donors"; // Ensure this matches your table name in SSMS
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
                            Name = reader["Name"]?.ToString() ?? "",
                            BloodType = reader["BloodType"]?.ToString() ?? "",
                            Phone_Number = reader["Phone_Number"]?.ToString() ?? "",
                            Address = reader["Address"]?.ToString() ?? "",
                            Gender = reader["Gender"]?.ToString() ?? ""
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
    }
}