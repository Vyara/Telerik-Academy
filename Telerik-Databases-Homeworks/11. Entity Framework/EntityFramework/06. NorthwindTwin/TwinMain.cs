namespace NorthwindTwin
{
    using System;
    using NorthwindContext;

    public class TwinMain
    {
        public static void Main()
        {
            var northwindDb = new NorthwindEntities();
            var twin = northwindDb.Database.CreateIfNotExists();

            // will create the Northwind DB if it doesn't exist, otherwise it will not
            Console.WriteLine("Was a Northwind twin created: {0}", twin ? "Yes" : "No");
        }
    }
}
