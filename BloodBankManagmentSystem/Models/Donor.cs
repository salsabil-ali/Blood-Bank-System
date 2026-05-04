using System;

namespace BloodBankManagmentSystem.Models
{
    public class Donor
    {
        public int Donor_ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string BloodType { get; set; } = string.Empty;
        public string Phone_Number { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
    }
}