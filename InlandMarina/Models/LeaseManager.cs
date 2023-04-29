using InlandMarina.Data;
using Microsoft.EntityFrameworkCore;

namespace InlandMarina.Models
{
    public class LeaseManager
    {
        public static List<Lease> GetCustomerLeases(InlandMarinaContext db, string cusUserName) // dependency injection
        {
            int customerId = CustomerManager.FindCustomer(cusUserName, db).ID;
            List<Lease> customerLeases = null;

            customerLeases = db.Leases.Include(s => s.Slip).Where(l => l.CustomerID == customerId).ToList(); // get leased slips' Ids to filter leased slips
            return customerLeases;
        }
    }
}
