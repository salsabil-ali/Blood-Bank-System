using System;
using BloodBankManagmentSystem.Models;
using BloodBankManagmentSystem.Data_Access_Layer;
class Program
{
    static void Main(string[] args)
    {
        BloodUnitDAL unitRepo = new BloodUnitDAL();
        RequestDAL requestRepo = new RequestDAL();

        try
        {
            // =========================
            // BLOOD UNIT FUNCTIONS
            // =========================

            Console.WriteLine("=== COUNT AVAILABLE UNITS ===");
            int count = unitRepo.CountAvailableUnits("A+");
            Console.WriteLine("A+ Available: " + count);

            Console.WriteLine("\n=== GET AVAILABLE BLOOD UNITS ===");
            var units = unitRepo.GetAvailableBloodUnits("A+");

            if (units.Count > 0)
            {
                foreach (var u in units)
                {
                    Console.WriteLine($"ID: {u.BloodUnit_ID}, Type: {u.Blood_Type}, Status: {u.Status}");
                }

                Console.WriteLine("\n=== UPDATE BLOOD UNIT STATUS ===");

                units[0].Status = "Used";
                unitRepo.UpdateBloodUnitStatus(units[0].BloodUnit_ID, units[0].Status);

                Console.WriteLine("First unit updated to Used");
            }
            else
            {
                Console.WriteLine("No blood units found.");
            }


            // =========================
            // BLOOD REQUEST FUNCTIONS
            // =========================

            Console.WriteLine("\n=== ADD BLOOD REQUEST ===");

            BloodRequest request = new BloodRequest
            {
                Request_Date = DateTime.Now,
                Blood_Type = "A+",
                Quantity_Requested = 2,
                Request_Status = "Pending",
                Hospital_ID = 1
            };

            requestRepo.AddRequest(request);

            Console.WriteLine("Request added successfully!");


            Console.WriteLine("\n=== GET ALL REQUESTS ===");

            var requests = requestRepo.GetAllRequests();

            if (requests.Count > 0)
            {
                foreach (var r in requests)
                {
                    Console.WriteLine($"ID: {r.Request_ID}, Type: {r.Blood_Type}, Status: {r.Request_Status}");
                }

                Console.WriteLine("\n=== UPDATE REQUEST STATUS ===");

                int id = requests[0].Request_ID;
                requestRepo.UpdateRequestStatus(id, "Approved");

                Console.WriteLine("First request updated to Approved");
            }
            else
            {
                Console.WriteLine("No requests found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: " + ex.Message);

            if (ex.InnerException != null)
            {
                Console.WriteLine("INNER: " + ex.InnerException.Message);
            }
        }

        Console.ReadLine();
    }
}






