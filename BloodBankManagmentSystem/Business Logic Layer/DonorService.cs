// ===============================
// DonorService.cs
// ===============================

using System;
using System.Collections.Generic;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;

namespace BloodBankManagmentSystem.Business_Logic_Layer
{
    public class DonorService
    {
        private DonorDAL donorDAL = new DonorDAL();

        public List<Donor> GetAllDonors()
        {
            return donorDAL.GetAllDonors();
        }

        public void AddDonor(Donor donor)
        {
            if (string.IsNullOrWhiteSpace(donor.Name))
                throw new Exception("Donor name is required");

            if (string.IsNullOrWhiteSpace(donor.Blood_Type))
                throw new Exception("Blood type is required");

            donorDAL.AddDonor(donor);
        }

        public void UpdateDonor(Donor donor)
        {
            if (donor.Donor_ID <= 0)
                throw new Exception("Invalid donor ID");

            donorDAL.UpdateDonor(donor);
        }

        public void DeleteDonor(int donorId)
        {
            if (donorId <= 0)
                throw new Exception("Invalid donor ID");

            donorDAL.DeleteDonor(donorId);
        }

        public void ClearDonor(int donorId)
        {
            if (donorId <= 0)
                throw new Exception("Invalid donor ID");

            donorDAL.ClearDonor(donorId);
        }

        public int GetDonorAge(DateTime birthDate)
        {
            return DateTime.Now.Year - birthDate.Year;
        }
    }
}