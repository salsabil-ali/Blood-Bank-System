using BloodBankManagmentSystem.Data_Access_Layer;
using BloodBankManagmentSystem.Models;
using System;
using System.Collections.Generic;

public class RequestService
{
    // You named it requestDAL here...
    private RequestDAL requestDAL = new RequestDAL();

    // ...so you must use requestDAL everywhere below!
    public List<BloodRequest> GetAllRequests() => requestDAL.GetAllRequests();

    public List<RequestDetails> GetRequestDetails(int id) => requestDAL.GetRequestDetails(id);

    public void CreateRequest(BloodRequest req) => requestDAL.AddBloodRequest(req);

    public void UpdateStatus(int id, string status) => requestDAL.UpdateRequestStatus(id, status);

    public void DeleteRequest(int id)
    {
        if (id <= 0) throw new Exception("Invalid ID.");

        requestDAL.DeleteRequest(id);
    }

    public BloodRequest SearchRequest(int id) => requestDAL.SearchByRequestID(id);
}