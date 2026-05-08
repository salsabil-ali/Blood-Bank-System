using System;

namespace BloodBankManagmentSystem.Models
{
    // Represents a donor with personal details and contact information.
    public class Donor
    {
        public int Donor_ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public string Blood_Type { get; internal set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
    }
}