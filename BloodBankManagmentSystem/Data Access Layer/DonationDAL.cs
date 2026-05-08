// ===============================
// DonationDAL.cs
// ===============================

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BloodBankManagmentSystem.Models;

namespace BloodBankManagmentSystem.Data_Access_Layer
{
    public class DonationDAL
    {
        // Data access for Donation entities: provides CRUD and related blood unit queries.

        // Retrieves all donations from the Donation table.
        public List<Donation> GetAllDonations()
        {
            List<Donation> donations = new List<Donation>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Donation";

                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Donation donation = new Donation
                        {
                            Donation_ID = Convert.ToInt32(reader["Donation_ID"]),
                            Donation_Date = Convert.ToDateTime(reader["Donation_Date"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            Donor_ID = Convert.ToInt32(reader["Donor_ID"])
                        };

                        donations.Add(donation);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving donations: " + ex.Message);
                }
            }

            return donations;
        }



        // Inserts a new donation record into the database.
        public void AddDonation(Donation donation)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"INSERT INTO Donation
                                (Donation_ID, Donation_Date, Quantity, Donor_ID)
                                VALUES
                                (@Donation_ID, @Donation_Date, @Quantity, @Donor_ID)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Donation_ID", donation.Donation_ID);
                cmd.Parameters.AddWithValue("@Donation_Date", donation.Donation_Date);
                cmd.Parameters.AddWithValue("@Quantity", donation.Quantity);
                cmd.Parameters.AddWithValue("@Donor_ID", donation.Donor_ID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error adding donation: " + ex.Message);
                }
            }
        }

        // Deletes a donation by ID from the Donation table.
        public void DeleteDonation(int donationId)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "DELETE FROM Donation WHERE Donation_ID = @Donation_ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Donation_ID", donationId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error deleting donation: " + ex.Message);
                }
            }
        }

        // Updates an existing donation's fields by ID.
        public void UpdateDonation(Donation donation)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"UPDATE Donation
                                 SET Donation_Date = @Donation_Date,
                                     Quantity = @Quantity,
                                     Donor_ID = @Donor_ID
                                 WHERE Donation_ID = @Donation_ID";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Donation_ID", donation.Donation_ID);
                cmd.Parameters.AddWithValue("@Donation_Date", donation.Donation_Date);
                cmd.Parameters.AddWithValue("@Quantity", donation.Quantity);
                cmd.Parameters.AddWithValue("@Donor_ID", donation.Donor_ID);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error updating donation: " + ex.Message);
                }
            }
        }

        // Searches for blood units by blood type and returns a list of BloodUnit models.
        public List<BloodUnit> SearchBloodUnits(string bloodType)
        {
            List<BloodUnit> units = new List<BloodUnit>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = @"SELECT *
                         FROM Blood_Unit
                         WHERE Blood_Type = @Blood_Type";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Blood_Type", bloodType);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        BloodUnit unit = new BloodUnit
                        {
                            BloodUnit_ID = Convert.ToInt32(reader["BloodUnit_ID"]),
                            Blood_Type = reader["Blood_Type"].ToString(),
                            Collection_Date = Convert.ToDateTime(reader["Collection_Date"]),
                            Expiration_Date = Convert.ToDateTime(reader["Expiration_Date"]),
                            Donation_ID = Convert.ToInt32(reader["Donation_ID"])
                        };

                        units.Add(unit);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error searching blood units: " + ex.Message);
                }
            }

            return units;
        }


        // Retrieves all blood units from the Blood_Unit table including status information.
        public List<BloodUnit> GetAllBloodUnits()
        {
            List<BloodUnit> units = new List<BloodUnit>();

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                string query = "SELECT * FROM Blood_Unit";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    BloodUnit unit = new BloodUnit
                    {
                        BloodUnit_ID = Convert.ToInt32(reader["BloodUnit_ID"]),
                        Blood_Type = reader["Blood_Type"].ToString(),
                        Collection_Date = Convert.ToDateTime(reader["Collection_Date"]),
                        Expiration_Date = Convert.ToDateTime(reader["Expiration_Date"]),
                        // Fixed the missing parenthesis here:
                        Donation_ID = Convert.ToInt32(reader["Donation_ID"]),
                        // This ensures the Status column is no longer empty in your grid:
                        Status = reader["Status"].ToString()
                    };

                    units.Add(unit);
                }
            }

            return units;
        }
    }
    }