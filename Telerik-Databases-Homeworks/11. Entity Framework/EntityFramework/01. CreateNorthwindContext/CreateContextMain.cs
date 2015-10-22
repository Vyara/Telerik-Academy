namespace NorthwindContext
{
    using System;
    using System.Linq;

    public class CreateContextMain
    {
        public static void Main()
        {
            var northwind = new NorthwindEntities();

            using (northwind)
            {
                Console.WriteLine("Showing all products in Northwind DB: ");
                Console.WriteLine();
                northwind.Products
                    .Select(p => p.ProductName)
                    .ToList()
                    .ForEach(p => Console.WriteLine("* " + p));
            }
        }
    }
}
