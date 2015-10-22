namespace ConcurencyTest
{
    using System;
    using System.Linq;
    using NorthwindContext;

    public class ConcurencyMain
    {
        public static void Main()
        {
            var firstConection = new NorthwindEntities();
            var secondConection = new NorthwindEntities();

            Console.WriteLine();
            var firstCustomer = firstConection.Customers.First();
            var secondCustomer = secondConection.Customers.First();

            Console.WriteLine("Name from first connection: " + firstCustomer.CompanyName);
            Console.WriteLine("Name from second connection: " + secondCustomer.CompanyName);

            firstCustomer.CompanyName = "Google";
            secondCustomer.CompanyName = "Microsoft";

            //// What will happen at SaveChanges()? - second company name change will be implemented
            //// How to deal with it? - either by using a single connection, or if not applicable - by introduction of transactions isolation levels

            firstConection.SaveChanges();
            secondConection.SaveChanges();

            var result = new NorthwindEntities().Customers.First();
            Console.WriteLine("Final company name {0}", result.CompanyName);
            Console.WriteLine();
        }
    }
}