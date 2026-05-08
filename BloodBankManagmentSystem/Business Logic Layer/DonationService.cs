using System;
using System.Collections.Generic;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;

namespace BloodBankManagmentSystem.Business_Logic_Layer
{
    public class DonationService
    {
        private DonationDAL donationDAL = new DonationDAL();

        // =========================
        // Add Donation
        // =========================

        public void AddDonation(Donation donation)
        {
            if (donation.Quantity <= 0)
                throw new Exception("Quantity must be greater than zero");

            if (donation.Donor_ID <= 0)
                throw new Exception("Invalid donor ID");

            donationDAL.AddDonation(donation);
        }

 

        public List<BloodUnit> SearchBloodUnits(string bloodType)
        {
            if (string.IsNullOrWhiteSpace(bloodType))
                throw new Exception("Blood type is required");

            return donationDAL.SearchBloodUnits(bloodType);
        }

        public List<BloodUnit> GetAllBloodUnits()
        {
            return donationDAL.GetAllBloodUnits();
        }
    }
}
