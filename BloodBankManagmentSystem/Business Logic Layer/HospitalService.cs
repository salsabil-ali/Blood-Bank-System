using System;
using System.Collections.Generic;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;
using System.Linq;

namespace BloodBankManagmentSystem.Business_Logic_Layer
{
    internal class HospitalService
    {
        // Business service for Hospital operations; performs validation and delegates to HospitalDAL.
        private HospitalDAL hospitalDAL = new HospitalDAL();

        // Returns all hospitals for UI components such as ComboBox or DataGrid.
        public List<Hospital> GetAllHospitals()
        {
            return hospitalDAL.GetAllHospitals();
        }

        // Retrieves a single hospital by ID after validating the provided ID.
        public Hospital GetHospitalById(int id)
        {
            if (id <= 0) throw new Exception("Invalid Hospital ID");

            return hospitalDAL.GetAllHospitals().FirstOrDefault(h => h.Hospital_ID == id);
        }

        // Validates and adds a new hospital record.
        public void AddHospital(Hospital hospital)
        {
            if (string.IsNullOrWhiteSpace(hospital.Hospital_Name))
                throw new Exception("Hospital Name is required");

            if (hospital.Hospital_ID <= 0)
                throw new Exception("Please provide a valid ID");

            hospitalDAL.AddHospital(hospital);
        }

        // Validates and updates an existing hospital's information.
        public void UpdateHospital(Hospital hospital)
        {
            if (hospital.Hospital_ID <= 0)
                throw new Exception("Select a hospital to update");

            hospitalDAL.UpdateHospital(hospital);
        }

        

        // Searches for a hospital by ID using DAL; validates input.
        public Hospital SearchHospital(int id)
        {
            if (id <= 0) throw new Exception("Please enter a valid Hospital ID.");
            return hospitalDAL.GetHospitalById(id);
        }

        // Removes a hospital after validating the provided ID.
        public void RemoveHospital(int id)
        {
            if (id <= 0) throw new Exception("Select a hospital to delete.");
            hospitalDAL.DeleteHospital(id);
        }

        // Clears non-key hospital fields by calling the DAL method.
        public void ClearHospitalData(int id)
        {
            if (id <= 0) throw new Exception("Please select a valid Hospital ID to clear.");
            hospitalDAL.ClearHospitalRecord(id);
        }
    }
}