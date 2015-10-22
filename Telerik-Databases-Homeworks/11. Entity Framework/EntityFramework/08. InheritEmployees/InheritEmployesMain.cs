namespace InheritEmployees
{
    using System;
    using System.Linq;
    using NorthwindContext;

    public class InheritEmployesMain
    {
        public static void Main()
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var employee = northwindEntities.Employees.First();
                //// this is refering to the EmployeeExtended.cs file in the 01. CreateNorthwindContext Project
                var territories = employee.TerritoriesSet;

                Console.WriteLine("Employee {0} {1} has the following teritories:", employee.FirstName, employee.LastName);
                Console.WriteLine(new string('-', 30));
                foreach (var territory in territories)
                {
                    Console.WriteLine(territory.TerritoryDescription);
                }
            }
        }
    }
}