using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankManagmentSystem.Models
{
    public class RequestDetails
    {
        public int Request_ID { get; set; }
        public int BloodUnit_ID { get; set; }
        public int Quantity_Allocated { get; set; }
    }
}
