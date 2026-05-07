using System;

namespace BloodBankManagmentSystem.Models
{
    public class Donor
    {
        public int Donor_ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Date_of_Birth { get; set; }

        
        public string Blood_Type { get; set; }
        public string BloodType
        {
            get => Blood_Type;
            set => Blood_Type = value;
        }

        public string Phone_Number { get; set; }
        public string Address { get; set; }
    }
}