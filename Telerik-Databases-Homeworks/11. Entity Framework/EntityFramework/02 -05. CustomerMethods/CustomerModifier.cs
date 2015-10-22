namespace DaoClassWithCrud
{
    using System;
    using System.Linq;
    using NorthwindContext;

    public class CustomerModifier
    {
        public static string InsertNewCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException("Customer cannot be null");
            }

            using (var northwindEntities = new NorthwindEntities())
            {
                northwindEntities.Customers.Add(customer);
                northwindEntities.SaveChanges();
                return customer.CustomerID;
            }
        }

        public static void ModifyCustomerCompanyName(string customerID, string newCompanyName)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var customer = GetCustomerById(northwindEntities, customerID);
                customer.CompanyName = newCompanyName;
                northwindEntities.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                Customer customer = GetCustomerById(northwindEntities, customerID);
                northwindEntities.Customers.Remove(customer);
                northwindEntities.SaveChanges();
            }
        }

        public static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerID)
        {
            var customer = northwindEntities.Customers
                .FirstOrDefault(c => c.CustomerID == customerID);

            return customer;
        }
    }
}
