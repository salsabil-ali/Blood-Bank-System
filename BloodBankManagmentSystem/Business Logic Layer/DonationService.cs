using System;
using System.Collections.Generic;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;

namespace BloodBankManagmentSystem.Business_Logic_Layer
{
    public class DonationService
    {
        // Business service for donation operations: validates inputs and delegates to DonationDAL.
        private DonationDAL donationDAL = new DonationDAL();

        // Validates and adds a donation record via the DAL.
        public void AddDonation(Donation donation)
        {
            if (donation.Quantity <= 0)
                throw new Exception("Quantity must be greater than zero");

            if (donation.Donor_ID <= 0)
                throw new Exception("Invalid donor ID");

            donationDAL.AddDonation(donation);
        }

 

        // Searches for blood units by type using the DAL and returns matching units.
        public List<BloodUnit> SearchBloodUnits(string bloodType)
        {
            if (string.IsNullOrWhiteSpace(bloodType))
                throw new Exception("Blood type is required");

            return donationDAL.SearchBloodUnits(bloodType);
        }

        // Retrieves all blood units via the DAL.
        public List<BloodUnit> GetAllBloodUnits()
        {
            return donationDAL.GetAllBloodUnits();
        }
    }
}
