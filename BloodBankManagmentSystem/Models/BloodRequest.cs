using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Models
{
    // Represents a blood request submitted by a hospital including requested type and quantity.
    public class BloodRequest
    {
        public int Request_ID { get; set; }
        public DateTime Request_Date { get; set; }
        public string Blood_Type { get; set; }
        public int Quantity_Requested { get; set; }
        public string Status { get; set; } // Pending, Approved, etc.
        public int Hospital_ID { get; set; }
    }
}
