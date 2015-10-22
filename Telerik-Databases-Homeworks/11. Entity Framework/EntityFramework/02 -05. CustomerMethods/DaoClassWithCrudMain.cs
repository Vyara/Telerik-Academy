namespace DaoClassWithCrud
{
    using System;
    using System.Linq;
    using NorthwindContext;

    public class DaoClassWithCrudMain
    {
        public static void Main()
        {
            var testCustomer = new Customer
            {
                CustomerID = "aaa",
                CompanyName = "Telerik"
            };

            Console.WriteLine("Inserting a new Customer with Id {0} : ", testCustomer.CustomerID);
            Console.WriteLine(new string('-', 30));
            TestInsertingCustomer(testCustomer);
            Console.WriteLine();

            Console.WriteLine("Modifying Customer's Company {0} : ", testCustomer.CompanyName);
            Console.WriteLine(new string('-', 30));
            TestMoodifyingCustomer(testCustomer.CustomerID);
            Console.WriteLine();

            Console.WriteLine("Deleting Customer with Id {0} : ", testCustomer.CustomerID);
            Console.WriteLine(new string('-', 30));
            TestDeleteingCustomer(testCustomer.CustomerID);
            Console.WriteLine();

            var northwindDb = new NorthwindEntities();

            Console.WriteLine("Displaying Customers who shipped to Canada in 1997: ");
            Console.WriteLine(new string('-', 30));
            FindCustomersByOrdersYearAndCountry(northwindDb, 1997, "Canada");
            Console.WriteLine();

            Console.WriteLine("Displaying Customers who shipped to Canada in 1997 (with native SQL): ");
            Console.WriteLine(new string('-', 30));
            FindCustomersByOrdersYearAndCountryWithNativeSql(northwindDb, 1997, "Canada");
            Console.WriteLine();

            Console.WriteLine("Displaying Orders shipped to Rio de Janeiro between 15 and 20 years ago.");
            Console.WriteLine(new string('-', 30));
            FindSalesByRegionAndTimePeriod(northwindDb, "RJ", DateTime.Now.AddYears(-20), DateTime.Now.AddYears(-15));
            Console.WriteLine();
        }

        // task 2 - Create a DAO class with static methods which provide functionality for inserting, modifying and deleting customers. Write a testing class.
        private static void TestInsertingCustomer(Customer newCustomer)
        {
            var newId = CustomerModifier.InsertNewCustomer(newCustomer);

            Console.WriteLine("Added a new customer with id {0}", newId);
        }

        private static void TestMoodifyingCustomer(string customerID)
        {
            CustomerModifier.ModifyCustomerCompanyName(customerID, "Google");

            var updatedCustomer = CustomerModifier.GetCustomerById(new NorthwindEntities(), customerID);

            Console.WriteLine("Customer's company name is {0}", updatedCustomer.CompanyName);
        }

        private static void TestDeleteingCustomer(string customerID)
        {
            CustomerModifier.DeleteCustomer(customerID);

            var nullCustomer = CustomerModifier.GetCustomerById(new NorthwindEntities(), customerID);

            Console.WriteLine("Customer with ID {0} exists? {1}", customerID, nullCustomer == null ? "No" : "Yes");
        }

        // task 3 - Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
        private static void FindCustomersByOrdersYearAndCountry(NorthwindEntities northwind, int year, string country)
        {
            northwind.Orders
                .Where(o => o.OrderDate.Value.Year == year && o.ShipCountry == country)
                .Select(ord => ord.Customer)
                .GroupBy(c => c.CompanyName)
                .ToList().ForEach(cust => Console.WriteLine("- " + cust.Key));
        }

        // task 4 - Implement previous by using native SQL query and executing it through the DbContext.
        private static void FindCustomersByOrdersYearAndCountryWithNativeSql(NorthwindEntities northwind, int year, string country)
        {
            string query = "SELECT c.CompanyName FROM Customers AS c " +
                            "JOIN Orders AS o " +
                            "ON c.CustomerId = o.CustomerId " +
                            "WHERE Country = '{0}' " +
                            "AND YEAR(OrderDate) = {1}" +
                            "GROUP BY c.CompanyName ";

            object[] parameters = { country, year };

            var customers = northwind.Database.SqlQuery<string>(string.Format(query, parameters));

            foreach (var customer in customers)
            {
                Console.WriteLine("- " + customer);
            }
        }

        private static void FindSalesByRegionAndTimePeriod(NorthwindEntities northwind, string region, DateTime startDate, DateTime endDate)
        {
            northwind.Orders
                .Where(o => o.ShipRegion == region &&
                        o.OrderDate >= startDate &&
                        o.OrderDate <= endDate)
                .Select(o => new { o.OrderID, o.ShipCity })
                .ToList()
                .ForEach(o => Console.WriteLine(string.Format("Order #{0} to {1}", o.OrderID, o.ShipCity)));
        }
    }
}
