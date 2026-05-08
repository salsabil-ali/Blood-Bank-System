using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Models
{
    // Model representing a Donation record with ID, date, quantity and donor reference.
    public class Donation
    {
        public int Donation_ID { get; set; }

        public DateTime Donation_Date { get; set; }

        public int Quantity { get; set; }

        public int Donor_ID { get; set; }
    }
}
