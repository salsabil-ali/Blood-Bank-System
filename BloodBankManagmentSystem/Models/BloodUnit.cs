using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Models
{
    public class BloodUnit
    {
        public int BloodUnit_ID { get; set; }
        public string Blood_Type { get; set; }
        public DateTime Collection_Date { get; set; }
        public DateTime Expiration_Date { get; set; }
        public string Status { get; set; } // Available / Used / Expired
        public int Donation_ID { get; set; }
    }
}
