using InlandMarina.Data;
using Microsoft.EntityFrameworkCore;

namespace InlandMarina.Models
{
    public static class CustomerManager
    {

        /// <summary>
        /// retries all Customers
        /// </summary>
        /// <returns>list of Customers in alphabetic order</returns>
        public static List<Customer> GetAll(InlandMarinaContext db) 
        {
            List<Customer> customers = db.Customers.OrderBy(c => c.FirstName).ToList();
            return customers;
        }

        /// <summary>
        /// User is authenticated based on credentials and a user returned if exists or null if not.
        /// </summary>
        /// <param name="username">Username as string</param>
        /// <param name="password">Password as string</param>
        /// <returns>A user object or null.</returns>
        /// <remarks>
        /// Add additional for the docs for this application--for developers.
        /// </remarks>
        public static Customer Authenticate(string username, string password, InlandMarinaContext db)
        {
            Customer cust = null;
            cust = db.Customers.SingleOrDefault(c => c.Username == username && c.Password == password);

            return cust; //this will either be null or an object
        }

        public static Customer FindCustomer(string username, InlandMarinaContext db)
        {
            
            Customer cust = null;

            cust = db.Customers.Include(d => d.Leases).SingleOrDefault(c => c.Username == username); // get available slips

            return cust; //this will either be null or an object
        }
    }
}
