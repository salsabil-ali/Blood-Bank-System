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

        public List<BloodUnit> GetAvailableUnits(string bloodType)
        {
            if (string.IsNullOrWhiteSpace(bloodType))
                throw new Exception("Blood type is required");

            return bloodUnitDAL.GetAvailableBloodUnits(bloodType);
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
    }
}