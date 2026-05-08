
using System;
using System.Collections.Generic;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;

namespace BloodBankManagmentSystem.Business_Logic_Layer
{
    public class DonorService
    {
        // Business layer for donor operations; validates inputs and delegates to DonorDAL.
        private DonorDAL donorDAL = new DonorDAL();

        // Returns all donors for UI consumption.
        public List<Donor> GetAllDonors()
        {
            return donorDAL.GetAllDonors();
        }

        // Validates and adds a new donor.
        public void AddDonor(Donor donor)
        {
            if (string.IsNullOrWhiteSpace(donor.Name))
                throw new Exception("Donor name is required");

            if (string.IsNullOrWhiteSpace(donor.Blood_Type))
                throw new Exception("Blood type is required");

            donorDAL.AddDonor(donor);
        }

        // Validates and updates an existing donor.
        public void UpdateDonor(Donor donor)
        {
            if (donor.Donor_ID <= 0)
                throw new Exception("Invalid donor ID");

            donorDAL.UpdateDonor(donor);
        }

        // Validates and deletes a donor by ID.
        public void DeleteDonor(int donorId)
        {
            if (donorId <= 0)
                throw new Exception("Invalid donor ID");

            donorDAL.DeleteDonor(donorId);
        }

        // Validates and clears donor data (non-key fields) by ID.
        public void ClearDonor(int donorId)
        {
            if (donorId <= 0)
                throw new Exception("Invalid donor ID");

            donorDAL.ClearDonor(donorId);
        }


        // Searches for a donor by ID after validation and returns the Donor model.
        public Donor SearchDonor(int donorId)
        {
            if (donorId <= 0)
                throw new Exception("Invalid donor ID");

            // This now returns the Donor object found by the DAL
            return donorDAL.SearchDonor(donorId);
        }
    }
}