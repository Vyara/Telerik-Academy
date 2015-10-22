/*
Write a program that retrieves from the Northwind database all product categories and the names of the products in each category.
Can you do this with a single SQL query (with table join)?
*/
namespace RetreiveAllProductCategoriesAndNames
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class RetreiveProductNames
    {
        public static void Main()
        {
            var dbCon = new SqlConnection("Server=.\\SQLEXPRESS; " +
                                                    "Database=Northwind; Integrated Security=true");

            dbCon.Open();

            using (dbCon)
            {
                var cmdProductCategoriesAndNames = new SqlCommand("SELECT ProductName, CategoryName " + "FROM Products p " + "JOIN Categories c " + "ON p.CategoryID = c.CategoryId", dbCon);

                var categories = new Dictionary<string, List<string>>();
                var reader = cmdProductCategoriesAndNames.ExecuteReader();

                using (reader)
                {
                    Console.WriteLine("   Categories   and   Products");
                    Console.WriteLine(new string('-', 100));
                    Console.WriteLine(new string('-', 100));

                    while (reader.Read())
                    {
                        var categoryName = (string)reader["CategoryName"];
                        var productName = (string)reader["ProductName"];

                        if (categories.ContainsKey(categoryName))
                        {
                            categories[categoryName].Add(productName);
                        }
                        else
                        {
                            categories.Add(categoryName, new List<string>());
                            categories[categoryName].Add(productName);
                        }
                    }
                }

                foreach (var category in categories)
                {
                    Console.WriteLine();
                    Console.WriteLine("{0}:  ", category.Key);
                    Console.WriteLine(new string('-', 100));
                    Console.WriteLine("{0}", string.Join(", ", category.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
