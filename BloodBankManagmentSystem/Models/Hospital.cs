using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Models
{
    // Model representing a Hospital with contact details used by requests and UI.
    public class Hospital
    {
        public int Hospital_ID { get; set; }
        public string Hospital_Name { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
    }
}
