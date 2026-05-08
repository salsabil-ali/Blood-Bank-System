// ===============================
// BloodUnitService.cs
// ===============================

using System;
using System.Collections.Generic;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;

namespace BloodBankManagmentSystem.Business_Logic_Layer
{
    public class BloodUnitService
    {
        private BloodUnitDAL bloodUnitDAL = new BloodUnitDAL();

        public List<BloodUnit> GetFilteredUnits(string bloodType, string status)
        {
            if (string.IsNullOrEmpty(bloodType) || string.IsNullOrEmpty(status))
                throw new Exception("Please select both Blood Type and Status.");

            return bloodUnitDAL.GetFilterBloodUnits(bloodType, status);
        }

        public void UpdateStatus(int bloodUnitId, string status)
        {
            if (bloodUnitId <= 0)
                throw new Exception("Invalid Blood Unit ID");

            if (string.IsNullOrWhiteSpace(status))
                throw new Exception("Status is required");

            bloodUnitDAL.UpdateBloodUnitStatus(bloodUnitId, status);
        }

        public int CountAvailable(string bloodType)
        {
            if (string.IsNullOrWhiteSpace(bloodType))
                throw new Exception("Blood type is required");

            return bloodUnitDAL.CountAvailableUnits(bloodType);
        }

        public List<BloodUnit> GetAllUnits()
        {
            return bloodUnitDAL.GetAllUnits();
        }
    }


}