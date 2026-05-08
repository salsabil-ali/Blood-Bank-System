using System;
using System.Collections.Generic;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;
using System.Linq;

namespace BloodBankManagmentSystem.Business_Logic_Layer
{
    internal class HospitalService
    {
        private HospitalDAL hospitalDAL = new HospitalDAL();

        // 1. Get all hospitals for the ComboBox or Grid
        public List<Hospital> GetAllHospitals()
        {
            return hospitalDAL.GetAllHospitals();
        }

        // 2. Get a single hospital (Useful when selecting from a grid)
        public Hospital GetHospitalById(int id)
        {
            if (id <= 0) throw new Exception("Invalid Hospital ID");

            return hospitalDAL.GetAllHospitals().FirstOrDefault(h => h.Hospital_ID == id);
        }

        // 3. Add a new hospital with validation
        public void AddHospital(Hospital hospital)
        {
            if (string.IsNullOrWhiteSpace(hospital.Hospital_Name))
                throw new Exception("Hospital Name is required");

            if (hospital.Hospital_ID <= 0)
                throw new Exception("Please provide a valid ID");

            hospitalDAL.AddHospital(hospital);
        }

        // 4. Update hospital details
        public void UpdateHospital(Hospital hospital)
        {
            if (hospital.Hospital_ID <= 0)
                throw new Exception("Select a hospital to update");

            hospitalDAL.UpdateHospital(hospital);
        }

        

        public Hospital SearchHospital(int id)
        {
            if (id <= 0) throw new Exception("Please enter a valid Hospital ID.");
            return hospitalDAL.GetHospitalById(id);
        }

        public void RemoveHospital(int id)
        {
            if (id <= 0) throw new Exception("Select a hospital to delete.");
            hospitalDAL.DeleteHospital(id);
        }

        public void ClearHospitalData(int id)
        {
            if (id <= 0) throw new Exception("Please select a valid Hospital ID to clear.");
            hospitalDAL.ClearHospitalRecord(id);
        }
    }
}