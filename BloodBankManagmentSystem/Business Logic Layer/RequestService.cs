using BloodBankManagmentSystem.Data_Access_Layer;
using BloodBankManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

// Business service for blood requests; validates input and delegates to RequestDAL.
public class RequestService
{
    private RequestDAL requestDAL = new RequestDAL();
   

    // Returns all blood requests for UI display.
    public List<BloodRequest> GetAllRequests() => requestDAL.GetAllRequests();

    // Retrieves allocated unit details for a specific request ID.
    public List<RequestDetails> GetRequestDetails(int id) => requestDAL.GetRequestDetails(id);

    // Creates a new blood request by delegating to the DAL.
    public void CreateRequest(BloodRequest req) => requestDAL.AddBloodRequest(req);


    

    // Deletes a request after validating the provided ID.
    public void DeleteRequest(int id)
    {
        if (id <= 0) throw new Exception("Invalid ID.");

        requestDAL.DeleteRequest(id);
    }

    // Searches for a request by ID and returns the BloodRequest if found.
    public BloodRequest SearchRequest(int id) => requestDAL.SearchByRequestID(id);


    public void UpdateHospitalRequest(BloodRequest req)
    {
        // Delegate the work to the DAL
        requestDAL.UpdateHospitalRequest(req);
    }


}